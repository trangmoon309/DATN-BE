using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Helpers;
using Datn.ApiManagement.Mock;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Linq;
using Volo.Abp.VirtualFileSystem;

namespace Datn.ApiManagement.MockDatas
{
    public class MockAppService : ApplicationService, IMockAppService
    {
        private readonly IVehicleLineRepository _lineRepository;
        private readonly IVehicleTypeRepository _typeRepository;
        private readonly IVehicleRepository _repository;
        private readonly IVirtualFileProvider _virtualFileProvider;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public MockAppService(IVehicleLineRepository lineRepository,
            IVehicleTypeRepository typeRepository,
            IVehicleRepository repository,
            IVirtualFileProvider virtualFileProvider, 
            IAsyncQueryableExecuter asyncQueryableExecuter)
        {
            _lineRepository = lineRepository;
            _typeRepository = typeRepository;
            _repository = repository;
            _virtualFileProvider = virtualFileProvider;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }

        public async Task<List<VehicleTypeResponse>> MockVehicleTypes()
        {
            var request = VehicleMock.VehicleTypes;
            var entities = new List<VehicleType>();
            foreach(var item in request)
            {
                var entity = ObjectMapper.Map<VehicleTypeRequest, VehicleType>(item);
                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.VehicleTypeDetails.ForEach(x =>
                {
                    x.VehicleTypeId = entity.Id;
                    EntityHelper.TrySetId(x, GuidGenerator.Create);
                });
                entity.Code = CodeAutoGenerationHelper.GetNextCode<VehicleType>(entities, "VT", 4);
                entities.Add(entity);
            }

            await _typeRepository.CreateMultiple(entities);
            return ObjectMapper.Map<List<VehicleType>, List<VehicleTypeResponse>>(entities);
        }

        public async Task<List<VehicleLineResponse>> MockVehicleLines()
        {
            var datas = _virtualFileProvider.GetFileInfo("/Resources/cars.xlsx");
            var entities = new List<VehicleLine>();
            if (datas.Exists)
            {
                var memoryStream = new MemoryStream();
                var fileContent = datas.CreateReadStream();

                using (var ep = new ExcelPackage(memoryStream, fileContent))
                {
                    var ws = ep.Workbook.Worksheets["cars"];

                    for (int rw = 2; rw <= ws.Dimension.End.Row; rw++)
                    {

                        if (ws.Cells[rw, 1].Value != null)
                        {
                            var name = ws.Cells[rw, 2].Value.ToString();
                            if(entities.Find(x => x.Name.Equals(name))  == null)
                            {
                                var entity = new VehicleLine();
                                entity.Name = name;
                                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                                entity.Code = CodeAutoGenerationHelper.GetNextCode<VehicleLine>(entities, "VL", 4);
                                entities.Add(entity);
                            }

                        }
                    }
                }
            }

            await _lineRepository.CreateMultiple(entities);
            return ObjectMapper.Map<List<VehicleLine>, List<VehicleLineResponse>>(entities);
        }

        public async Task<List<VehicleResponse>> MockVehicles()
        {
            var datas = _virtualFileProvider.GetFileInfo("/Resources/cars.xlsx");
            var entities = new List<Vehicle>();
            var types = await _asyncQueryableExecuter.ToListAsync(_typeRepository.GetList());
            var lines = await _asyncQueryableExecuter.ToListAsync(_lineRepository.GetList());
            double rentalPrice = 20;
            double depositPrice = 5;

            if (datas.Exists)
            {
                var memoryStream = new MemoryStream();
                var fileContent = datas.CreateReadStream();

                using (var ep = new ExcelPackage(memoryStream, fileContent))
                {
                    var ws = ep.Workbook.Worksheets["cars"];

                    for (int rw = 2; rw <= ws.Dimension.End.Row; rw++)
                    {
                        int count = 0;
                        var name = ws.Cells[rw, 1].Value.ToString().Substring(5);
                        var type = types.FirstOrDefault(x => name.Contains(x.Name));
                        var line = lines.FirstOrDefault(x => name.Contains(x.Name));
                        if (type != null && line != null)
                        {
                            var entity = new Vehicle();
                            entity.VehicleProperties = new List<VehicleProperty>();
                            int pos = name.IndexOf(type.Name);

                            name = name.Remove(pos, type.Name.Length);
                            if (entities.FirstOrDefault(x => x.Name == name) != null) continue;
                            entity.Name = name;
                            entity.VehicleTypeId = type.Id;
                            entity.VehicleLineId = line.Id;
                            entity.Amount = 10;
                            entity.KilometerTravel = 500;
                            entity.RentalPrice = rentalPrice;
                            entity.DepositPrice = depositPrice;
                            entity.LicensePlate = String.Empty;
                            entity.Color = "Black, While, Gray, Red, Blue";

                            entity.Code = CodeAutoGenerationHelper.GetNextCode<Vehicle>(entities, "V", 5);
                            EntityHelper.TrySetId(entity, GuidGenerator.Create);

                            type.VehicleTypeDetails.ForEach(x =>
                            {
                                if(count <= 5)
                                {
                                    var prop = new VehicleProperty()
                                    {
                                        VehicleId = entity.Id,
                                        VehicleTypeDetailId = x.Id
                                    };
                                    EntityHelper.TrySetId(prop, GuidGenerator.Create);

                                    entity.VehicleProperties.Add(prop);
                                }
                                count++;
                            });

                            entities.Add(entity);
                            rentalPrice += 11;
                            depositPrice += 12;
                        }
                    }
                }
            }

            _repository.CreateMultiple(entities);
            return ObjectMapper.Map<List<Vehicle>, List<VehicleResponse>>(entities);
        }

    }
}
