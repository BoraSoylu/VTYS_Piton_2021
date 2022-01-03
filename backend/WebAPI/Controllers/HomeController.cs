using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICitizenService citizenService;

        public HomeController(ICitizenService service)
        {
            citizenService = service;
        }

        //Prepared methods
        



        //end-

        [HttpPost("complaints/create"), Authorize(Roles = "Citizen")]
        public IActionResult CreateComplaint(ComplaintCreateDTO dto)
        {
            return Ok(this.citizenService.CreateComplaint(dto));
        }





        [HttpGet("{id}"), Authorize(Roles = "Citizen")]
        public Citizen Get(int id)
        {
            var result = citizenService.GetbyID(id);
            //if (result.Success)
            return result.Data;
        }
        [HttpGet("citizens")]
        public IActionResult GetAll()
        {
            var result = citizenService.GetAll();
            return Ok(result.Data);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetCitizenAuth(int id)
        //{
        //    var result = citizenService.GetCitizenAuthbyID(id);
        //    return Ok(result.Data);
        //}


        //[HttpGet("{email}")]
        //public IActionResult GetbyMail(string email)
        //{
        //    var result = citizenService.GetbyMail(email);
        //    return Ok(result.Data);
        //}

    }
}
