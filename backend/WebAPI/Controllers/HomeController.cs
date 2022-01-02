using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICitizenService citizenService;

        public HomeController(ICitizenService service)
        {
            citizenService = service;
            
        }

        [HttpGet]
        public Citizen Get()
        {
            var result = citizenService.GetbyID(1);
            //if (result.Success)
                return result.Data;

        }
    }
}
