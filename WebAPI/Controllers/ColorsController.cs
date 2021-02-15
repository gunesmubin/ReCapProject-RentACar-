using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
            
        }


        [HttpGet("ColorGetAll")]
        public IActionResult ColorGetAll()
        {
            var result = _colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("ColorAdd")]
        public IActionResult ColorAdd(Color Color)
        {
            var result = _colorService.AddColor(Color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("ColorDelete")]
        public IActionResult ColorDelete(Color Color)
        {
            var result = _colorService.DeleteColor(Color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("ColorUpdate")]
        public IActionResult ColorUpdate(Color Color)
        {
            var result = _colorService.UpdateColor(Color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}