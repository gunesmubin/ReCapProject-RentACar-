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
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
            
        }


        [HttpGet("UserGetAll")]
        public IActionResult UserGetAll()
        {
            var result = _userService.GetAllUser();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("UserGetById")]
        public IActionResult UserGetById(int id)
        {
            var result = _userService.GetUserById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("UserAdd")]
        public IActionResult UserAdd(User User)
        {
            var result = _userService.AddUser(User);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("UserDelete")]
        public IActionResult UserDelete(User User)
        {
            var result = _userService.DeleteUser(User);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("UserUpdate")]
        public IActionResult UserUpdate(User User)
        {
            var result = _userService.UpdateUser(User);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}