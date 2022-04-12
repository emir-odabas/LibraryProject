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
    public class WrittersController : ControllerBase
    {
        IWriterService _writerService;

        public WrittersController(IWriterService writerService)
        {
            _writerService= writerService;
        }

        [HttpGet("get")]
        public IActionResult GetAll()
        {
            var result = _writerService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Writer writer)
        {
            var result = _writerService.Add(writer);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Writer writer)
        {
            var result = _writerService.Update(writer);
            if (result.Success)
            {
                return Ok(writer);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Writer writer)
        {
            var result = _writerService.Update(writer);

            if (result.Success)
            {
                return Ok(writer);
            }

            return BadRequest(result);
        }




    }



}
