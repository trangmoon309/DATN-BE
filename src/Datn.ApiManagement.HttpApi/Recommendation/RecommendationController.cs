﻿using Datn.ApiManagement.Services;
using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using System.Net;
using System.Net.Http;
using Datn.ApiManagement.Mock;

namespace Datn.ApiManagement.Controllers
{
    [Route("api/recommend")]
    public class RecommendationController : ApiManagementController
    {
        private readonly IRecommendationAppService _service;

        public RecommendationController(IRecommendationAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-props/by-user/{userId}")]
        public async Task<IActionResult> MockVehicleTypes(Guid userId, SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetVehicleTypeDetailRecommended(userId, request, pageRequest);
            return Ok(result);
        }

        [HttpGet]
        [Route("tracking-changes")]
        public IActionResult TrackChange()
        {
            var result = _service.TrackChange();
            return Ok(result);
        }
    }
}
