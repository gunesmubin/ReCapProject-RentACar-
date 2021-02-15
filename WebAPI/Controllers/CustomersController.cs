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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
            
        }


        [HttpGet("CustomerGetAll")]
        public IActionResult CustomerGetAll()
        {
            var result = _customerService.GetAllCustomer();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("CustomerGetById")]
        public IActionResult CustomerGetById(int id)
        {
            var result = _customerService.GetCustomerById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("CustomerAdd")]
        public IActionResult CustomerAdd(Customer Customer)
        {
            var result = _customerService.AddCustomer(Customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("CustomerDelete")]
        public IActionResult CustomerDelete(Customer Customer)
        {
            var result = _customerService.DeleteCustomer(Customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("CustomerUpdate")]
        public IActionResult CustomerUpdate(Customer Customer)
        {
            var result = _customerService.UpdateCustomer(Customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}