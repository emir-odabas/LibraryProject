using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarsController : ControllerBase
    {
        IYazarService _yazarService;

        public YazarsController(IYazarService yazarService)
        {
            _yazarService = yazarService;
        }

        [HttpGet("get")]
        public IActionResult GetAll()
        {
            var result = _yazarService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Yazar yazar)
        {
            var result = _yazarService.Add(yazar);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Yazar yazar)
        {
            var result = _yazarService.Update(yazar);
            if (result.Success)
            {
                return Ok(yazar);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Yazar yazar)
        {
            var result = _yazarService.Update(yazar);

            if (result.Success)
            {
                return Ok(yazar);
            }

            return BadRequest(result);
        }




    }



}
