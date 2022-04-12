using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        ITypeService _typeService;

        public TypesController(ITypeService typeService)
        {
            _typeService= typeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _typeService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Entities.Concrete.Type type)
        {
            var result = _typeService.Add(type);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Entities.Concrete.Type type)
        {
            var result = _typeService.Update(type);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Entities.Concrete.Type type)
        {
            var result = _typeService.Delete(type);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }




    }
}
