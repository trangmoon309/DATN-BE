using Datn.ApiManagement.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IUserAppService :
            ICrudAppService<
                UserResponse,
                Guid,
                PagedAndSortedResultRequestDto,
                UserRequest,
                UserRequest>
    {
        Task<UserResponse> UpdateCurrentProfile(ProfileRequest request);

        Task<UserResponse> GetCurrentUser();

        Task<UserResponse> SignUpCustom(UserRequest request);
    }
}