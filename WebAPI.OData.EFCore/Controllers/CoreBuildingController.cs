﻿using AutoMapper;
using AutoMapper.AspNet.OData;
using DAL.EFCore;
using Domain.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.Threading.Tasks;

namespace WebAPI.OData.EFCore.Controllers
{
    public class CoreBuildingController : ODataController
    {
        private readonly MyDbContext _repository;
        private readonly IMapper _mapper;

        public CoreBuildingController(MyDbContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ODataQueryOptions<CoreBuilding> options)
        {
            return Ok(await _repository.BuildingSet.GetQueryAsync(_mapper, options, new QuerySettings { ODataSettings = new ODataSettings { HandleNullPropagation = HandleNullPropagationOption.False } }));
        }
    }
}
