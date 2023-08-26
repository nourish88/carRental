﻿
using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Quries.GetById;
using Application.Features.Brands.Quries.GetList;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    { 

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
          var response=   await Mediator?.Send(createBrandCommand)!;
          return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var getListBrandQuery = new GetListBrandQuery { PageRequest = pageRequest };
            var response=   await Mediator?.Send(getListBrandQuery)!;
            return Ok(response);
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var getByIdBrandQuery = new GetByIdBrandQuery() {Id = id};
            var response=   await Mediator?.Send(getByIdBrandQuery)!;
            return Ok(response);
        }
    }
}
