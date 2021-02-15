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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
            
        }


        [HttpGet("BrandGetAll")]
        public IActionResult BrandGetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("BrandAdd")]
        public IActionResult BrandAdd(Brand Brand)
        {
            var result = _brandService.AddBrand(Brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("BrandDelete")]
        public IActionResult BrandDelete(Brand Brand)
        {
            var result = _brandService.DeleteBrand(Brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("BrandUpdate")]
        public IActionResult BrandUpdate(Brand Brand)
        {
            var result = _brandService.UpdateBrand(Brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}