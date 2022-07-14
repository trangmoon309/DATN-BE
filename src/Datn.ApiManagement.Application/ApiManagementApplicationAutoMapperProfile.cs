using AutoMapper;
using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Volo.Abp.Data;
using Volo.Abp.Identity;

namespace Datn.ApiManagement;

public class ApiManagementApplicationAutoMapperProfile : Profile
{
    public ApiManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<User, UserResponse>(MemberList.None);
        CreateMap<UserRequest, User>(MemberList.None)
            .ForMember(x => x.NormalizedUserName, y => y.MapFrom(y => y.UserName.ToUpper()))
            .ForMember(x => x.NormalizedEmail, y => y.MapFrom(y => y.Email.ToUpper()))
            .ForMember(x => x.Surname, y => y.MapFrom(y => y.LastName))
            .ForMember(x => x.Name, y => y.MapFrom(y => y.FirstName));

        CreateMap<IdentityUser, UserResponse>(MemberList.None)
            .ForMember(x => x.LockoutEnd, y => y.Ignore());
        CreateMap<UserRequest, IdentityUser>(MemberList.None)
            .ForMember(x => x.NormalizedUserName, y => y.MapFrom(y => y.UserName.ToUpper()))
            .ForMember(x => x.NormalizedEmail, y => y.MapFrom(y => y.Email.ToUpper()))
            .ForMember(x => x.Surname, y => y.MapFrom(y => y.LastName))
            .ForMember(x => x.Name, y => y.MapFrom(y => y.FirstName));

        CreateMap<Role, RoleResponse>(MemberList.None);
        CreateMap<RoleRequest, Role>(MemberList.None);

        CreateMap<UserRole, UserRoleResponse>(MemberList.None);
        CreateMap<UserRoleRequest, UserRole>(MemberList.None);

        CreateMap<FileInformation, FileInformationResponse>(MemberList.None);
        CreateMap<FileInformationRequest, FileInformation>(MemberList.None);

        CreateMap<UserCart, UserCartResponse>(MemberList.None);
        CreateMap<UserCartRequest, UserCart>(MemberList.None);

        CreateMap<UserFavoriteVehicle, UserFavoriteVehicleResponse>(MemberList.None);
        CreateMap<UserFavoriteVehicleRequest, UserFavoriteVehicle>(MemberList.None);

        CreateMap<UserTransaction, UserTransactionResponse>(MemberList.None);
        CreateMap<UserTransactionRequest, UserTransaction>(MemberList.None);
        CreateMap<UpdateUserTransactionRequest, UserTransaction>(MemberList.None);

        CreateMap<UserTransactionVehicle, UserTransactionVehicleResponse>(MemberList.None)
            .ForMember(x => x.Transaction, y => y.Ignore());
        CreateMap<UserTransactionVehicleRequest, UserTransactionVehicle>(MemberList.None);
        CreateMap<UpdateUserTransactionVehicleRequest, UserTransactionVehicle>(MemberList.None);

        CreateMap<Vehicle, VehicleResponse>(MemberList.None);
        CreateMap<VehicleRequest, Vehicle>(MemberList.None);
        CreateMap<UpdateVehicleRequest, Vehicle>(MemberList.None);

        CreateMap<VehicleProperty, VehiclePropertyResponse>(MemberList.None);
        CreateMap<VehiclePropertyRequest, VehicleProperty>(MemberList.None);
        CreateMap<UpdateVehiclePropertyRequest, VehicleProperty>(MemberList.None);

        CreateMap<VehicleLine, VehicleLineResponse>(MemberList.None);
        CreateMap<VehicleLineRequest, VehicleLine>(MemberList.None);

        CreateMap<VehicleImage, VehicleImageResponse>(MemberList.None);
        CreateMap<VehicleImageRequest, VehicleImage>(MemberList.None);

        CreateMap<VehicleType, VehicleTypeResponse>(MemberList.None);
        CreateMap<VehicleTypeRequest, VehicleType>(MemberList.None);
        CreateMap<UpdateVehicleTypeRequest, VehicleType>(MemberList.None);

        CreateMap<VehicleTypeDetail, VehicleTypeDetailResponse>(MemberList.None);
        CreateMap<VehicleTypeDetailRequest, VehicleTypeDetail>(MemberList.None);
        CreateMap<UpdateVehicleTypeDetailRequest, VehicleTypeDetail>(MemberList.None);
    }
}
