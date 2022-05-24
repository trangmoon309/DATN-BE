using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PBL6.Hreo.Repository;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;
using Volo.Abp.Linq;
using Volo.Abp.Users;

namespace Datn.ApiManagement.Services
{
    [RemoteService(IsMetadataEnabled = false)]
    public class UserAppService :
        CrudAppService<
            User,
            UserResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserRequest,
            UserRequest>,
        IUserAppService
    {
        private readonly ICurrentUser _currentUser;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        private readonly IDataFilter _dataFilter;
        private readonly IConfiguration _config;
        private readonly IUserRepository _repository;
        private readonly IProfileImageAppService _profileAppService;

        protected IdentityUserManager UserManager { get; }

        public UserAppService(
            ICurrentUser currentUser,
            IUserRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IDataFilter dataFilter,
            IConfiguration config,
            IdentityUserManager userManager, 
            IProfileImageAppService profileAppService) : base(repository)
        {
            _currentUser = currentUser;
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _dataFilter = dataFilter;
            _config = config;
            UserManager = userManager;
            _profileAppService = profileAppService;
        }

        public async Task<UserResponse> GetCurrentUser()
        {
            try
            {
                var result = new UserResponse();

                if (_currentUser.Id.HasValue)
                {
                    var users = await _repository.GetById(_currentUser.Id.Value);
                    var user = await _asyncQueryableExecuter.FirstOrDefaultAsync(users);

                    if (user != null)
                    {
                        result = ObjectMapper.Map<User, UserResponse>(user);
                        var extraInforResponse = new ExtraInfors();

                        foreach (var item in user.ExtraProperties)
                        {
                            var value = item.Value;
                            extraInforResponse.GetType().GetProperty(item.Key).SetValue(extraInforResponse, value);
                        }
                        result.ExtraInfors = extraInforResponse;
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<UserResponse> UpdateCurrentProfileAvatar(IFormFile avatar)
        {
            try
            {
                var response = new UserResponse();

                if (_currentUser.Id.HasValue)
                {
                    var user = await UserManager.FindByIdAsync(_currentUser.Id.Value.ToString());

                    if (user != null)
                    {
                        var images = await _profileAppService.SaveProfileImageAsync(new List<IFormFile>() { avatar });
                        var extraInforResponse = new ExtraInfors();

                        user.SetProperty("AvatarId", images.FirstOrDefault().Id);
                        await UserManager.UpdateAsync(user);

                        foreach (var item in extraInforResponse.GetType().GetProperties())
                        {
                            var value = user.GetProperty<string>(item.Name);
                            extraInforResponse.GetType().GetProperty(item.Name).SetValue(extraInforResponse, value);
                        }

                        response = ObjectMapper.Map<IdentityUser, UserResponse>(user);
                        response.ExtraInfors = extraInforResponse;
                    }
                }
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<UserResponse> UpdateCurrentProfile(ProfileRequest request)
        {
            try
            {
                var response = new UserResponse();

                if (_currentUser.Id.HasValue)
                {
                    var user = await UserManager.FindByIdAsync(_currentUser.Id.Value.ToString());

                    if (user != null)
                    {

                        user.Surname = request.LastName;
                        user.Name = request.FirstName;
                        user.SetPhoneNumber(request.PhoneNumber, true);

                        var extraInforResponse = new ExtraInfors();

                        foreach (var item in request.ExtraInfors.GetType().GetProperties())
                        {
                            var value = item.GetValue(request.ExtraInfors);
                            user.SetProperty(item.Name, value);
                            extraInforResponse.GetType().GetProperty(item.Name).SetValue(extraInforResponse, value);
                        }

                        await UserManager.UpdateAsync(user);

                        response = ObjectMapper.Map<IdentityUser, UserResponse>(user);
                        response.ExtraInfors = extraInforResponse;
                    }
                }
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<UserResponse> SignUpCustom(UserRequest request)
        {
            try
            {
                var newUser = ObjectMapper.Map<UserRequest, IdentityUser>(request);
                newUser.SetIsActive(true);

                var extraInforResponse = new ExtraInfors();

                foreach(var item in request.ExtraInfors.GetType().GetProperties())
                {
                    var value = item.GetValue(request.ExtraInfors);
                    newUser.SetProperty(item.Name, value);
                    extraInforResponse.GetType().GetProperty(item.Name).SetValue(extraInforResponse, value);
                }
                EntityHelper.TrySetId(newUser, GuidGenerator.Create);

                var result = await UserManager.CreateAsync(newUser, request.Password);
                
                if(result.Succeeded == false)
                {
                    var errors = result.Errors.ToList();
                    throw new UserFriendlyException(errors[0].Description);
                }

                var response = ObjectMapper.Map<IdentityUser, UserResponse>(newUser);
                response.ExtraInfors = extraInforResponse;

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}