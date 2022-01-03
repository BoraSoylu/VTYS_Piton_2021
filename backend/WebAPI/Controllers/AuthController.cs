using Business.Abstract;
using Business.Conrete;
using Business.Utilities.Results;
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
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authenticationService;

        public AuthController(IAuthService service)
        {
            authenticationService = service;
        }


        [HttpPost("register")]
        public IActionResult CitizenRegister([FromBody] CitizenRegisterDTO dto)
        {
            var result = authenticationService.RegisterCitizen(dto);
            
            return Ok(result.Data.CitizenID);
        }


        [HttpPost("citizens/login")]
        public ActionResult<string> CitizenLogin(CitizenLoginDTO citizenLogin)
        {
            IDataResult<Citizen> clogin = authenticationService.LoginCitizen(citizenLogin);

            if (!clogin.Success)
                return BadRequest(clogin.InfoMessage);

            var result = this.authenticationService.CreateToken(clogin.Data);
            if (result.Success)
                return Ok(result);

            return BadRequest(result.InfoMessage);
        }



    }
}
