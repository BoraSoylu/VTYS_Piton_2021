using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICitizenService citizenService;
        private readonly Business.Abstract.IAuthorizationService authorizationService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ICitizenService service, Business.Abstract.IAuthorizationService authorizationService
            , IHttpContextAccessor context)
        {
            citizenService = service;
            this.authorizationService = authorizationService;
            this._httpContextAccessor = context;
        }

      


        //Prepared methods
        #region Authorizations
        [HttpGet("auths/alldata"), Authorize(Roles = "Citizen")]
        public IActionResult GetAllAuthorizations()
        {
            var result = this.authorizationService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet("auths/alltypes"), Authorize(Roles = "Citizen")]
        public IActionResult GetAllAuthorizationTypes()
        {
            var result = this.authorizationService.GetAllAuthTypes();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet("auths/{id}"), Authorize(Roles = "Citizen")]
        public IActionResult GetAuthorizationbyID(int id)
        {
            var result = this.authorizationService.GetbyID(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("auths/create"), Authorize(Roles = "Citizen")]
        public IActionResult AddNewAuthorizationType(AuthorizationDTO auth)
        {
            var result = this.authorizationService.Add(auth);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        #endregion


        [HttpPost("complaints/create"), Authorize(Roles = "Citizen")]
        public IActionResult CreateComplaint(ComplaintCreateDTO dto)
        {
            var id = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                id = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
            var result = this.citizenService.CreateComplaint(dto, int.Parse(id));

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        





        //end-





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
