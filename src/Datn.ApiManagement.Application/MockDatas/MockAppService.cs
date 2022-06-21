using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Helpers;
using Datn.ApiManagement.Mock;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.VirtualFileSystem;

namespace Datn.ApiManagement.MockDatas
{
    public class MockAppService : ApplicationService, IMockAppService
    {
        private readonly IVehicleLineRepository _lineRepository;
        private readonly IVehicleTypeRepository _typeRepository;
        private readonly IVehicleRepository _repository;
        private readonly IVirtualFileProvider _virtualFileProvider;

        public MockAppService(IVehicleLineRepository lineRepository,
            IVehicleTypeRepository typeRepository,
            IVehicleRepository repository, 
            IVirtualFileProvider virtualFileProvider)
        {
            _lineRepository = lineRepository;
            _typeRepository = typeRepository;
            _repository = repository;
            _virtualFileProvider = virtualFileProvider;
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
            if (datas.Exists)
            {
                var memoryStream = new MemoryStream();
                var fileContent = datas.CreateReadStream();

                using (var ep = new ExcelPackage(memoryStream, fileContent))
                {
                    var ws = ep.Workbook.Worksheets["cars"];

                    for (int rw = 2; rw <= ws.Dimension.End.Row; rw++)
                    {

                        var name = ws.Cells[rw, 2].Value.ToString();
                        if (entities.Find(x => x.Name.Equals(name)) == null)
                        {
                            var entity = new Vehicle();
                            entity.Name = name;
                            EntityHelper.TrySetId(entity, GuidGenerator.Create);
                            entity.Code = CodeAutoGenerationHelper.GetNextCode<Vehicle>(entities, "V", 5);
                            entities.Add(entity);
                        }
                    }
                }
            }

            await _repository.CreateMultiple(entities);
            return ObjectMapper.Map<List<Vehicle>, List<VehicleResponse>>(entities);
        }

    }
}
