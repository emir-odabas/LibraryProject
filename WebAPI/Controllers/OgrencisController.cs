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
    public class OgrencisController : ControllerBase
    {
        IOgrenciService _ogrenciService;

        public OgrencisController(IOgrenciService ogrenciService)
        {
            _ogrenciService = ogrenciService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _ogrenciService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Ogrenci ogrenci)
        {
            var result = _ogrenciService.Add(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Ogrenci ogrenci)
        {
            var result = _ogrenciService.Update(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Ogrenci ogrenci)
        {
            var result = _ogrenciService.Delete(ogrenci);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


    }
}
