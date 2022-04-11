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
    public class TursController : ControllerBase
    {
        ITurService _turService;

        public TursController(ITurService turService)
        {
            _turService = turService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _turService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Entities.Concrete.Type tur)
        {
            var result = _turService.Add(tur);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Entities.Concrete.Type tur)
        {
            var result = _turService.Update(tur);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Entities.Concrete.Type tur)
        {
            var result = _turService.Delete(tur);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }




    }
}
