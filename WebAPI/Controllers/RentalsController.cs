using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        
        [HttpPost("RentCar")]
        public IActionResult RentCar(Rental rental)
        {
            if (rental==null)
            {
                var resError = new ErrorResult(Messages.RentalIsEmpty);
                return BadRequest(resError);
            }
            var res = _rentalService.RentCar(rental);
            if (res.Success)
            {
                return Ok(res);

            }
            return BadRequest(res);
        }
        [HttpPost("RentBackCar")]
        public IActionResult RentBackCar(Rental rental)
        {
            if (rental == null)
            {
                var resError = new ErrorResult(Messages.RentalIsEmpty);
                return BadRequest(resError);
            }
            var res = _rentalService.RentBackCar(rental);
            if (res.Success)
            {
                return Ok(res);

            }
            return BadRequest(res);
        }
        [HttpGet("RentGetAll")]
        public IActionResult RentGetAll()
        {
            var res = _rentalService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

    }
}