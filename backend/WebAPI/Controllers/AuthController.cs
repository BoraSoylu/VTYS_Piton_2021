﻿using Business.Abstract;
using Business.Conrete;
using Business.Utilities.Results;
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
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authenticationService;

        public AuthController(IAuthService service)
        {
            authenticationService = service;
        }


        [HttpPost("citizens/register")]
        public IActionResult CitizenRegister([FromBody] RegisterDTO dto)
        {
            var result = authenticationService.RegisterCitizen(dto);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpPost("staffs/register"), Authorize(Roles = "Admin")]
        public IActionResult StaffRegister(StaffRegisterDTO dto)
        {
            var result = authenticationService.RegisterStaff(dto);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }


        [HttpPost("citizens/login")]
        public ActionResult<string> CitizenLogin(LoginDTO citizenLogin)
        {
            IDataResult<Citizen> clogin = authenticationService.LoginCitizen(citizenLogin);

            if (!clogin.Success)
                return BadRequest(clogin.InfoMessage);

            var result = this.authenticationService.CreateToken(clogin.Data);
            if (result.Success)
                return Ok(result);

            return BadRequest(result.InfoMessage);
        }

        [HttpPost("staffs/login")]
        public IActionResult StaffLogin(LoginDTO staffLogin)
        {
            var login = this.authenticationService.LoginStaff(staffLogin);

            if (!login.Success)
                return BadRequest(login.InfoMessage);

            var result = this.authenticationService.CreateToken(login.Data);

            return Ok(result);

        }


    }
}
