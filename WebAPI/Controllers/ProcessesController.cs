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
    public class ProcessesController : ControllerBase
    {
        IProcessService _processService;


        public ProcessesController(IProcessService processService)
        {
            _processService= processService;
        }

        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            var result = _processService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result); ;
        }

        [HttpPost("add")]
        public IActionResult Add(Process process)
        {
            var result = _processService.Add(process);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpPut("update")]
        public IActionResult Update(Process process)
        {
            var result = _processService.Update(process);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpDelete("delete")]
        public IActionResult Delete(Process process)
        {
            var result = _processService.Delete(process);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

    }
}
