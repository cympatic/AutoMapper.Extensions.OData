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
    public class OpsTenantController : ODataController
    {
        private readonly MyDbContext _repository;
        private readonly IMapper _mapper;

        public OpsTenantController(MyDbContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ODataQueryOptions<OpsTenant> options)
        {
            return Ok(await _repository.MandatorSet.GetQueryAsync(_mapper, options, new QuerySettings { ODataSettings = new ODataSettings { HandleNullPropagation = HandleNullPropagationOption.False } }));
        }
    }
}
