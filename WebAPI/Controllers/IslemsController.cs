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
    public class IslemsController : ControllerBase
    {
        IIslemService _islemService;


        public IslemsController(IIslemService islemService)
        {
            _islemService = islemService;
        }

        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            var result = _islemService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result); ;
        }

        [HttpPost("add")]
        public IActionResult Add(Islem islem)
        {
            var result = _islemService.Add(islem);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpPut("update")]
        public IActionResult Update(Islem islem)
        {
            var result = _islemService.Update(islem);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpDelete("delete")]
        public IActionResult Delete(Islem islem)
        {
            var result = _islemService.Delete(islem);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

    }
}
