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
    public class KitapsController : ControllerBase
    {
        private IKitapService _kitapService;

        public KitapsController(IKitapService kitapService)
        {
            _kitapService = kitapService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _kitapService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Kitap kitap)
        {
            var result = _kitapService.Add(kitap);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]

        public IActionResult Update(Kitap kitap)
        {
            var result = _kitapService.Update(kitap);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpDelete("delete")]

        public IActionResult Delete(Kitap kitap)
        {
            var result = _kitapService.Update(kitap);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
