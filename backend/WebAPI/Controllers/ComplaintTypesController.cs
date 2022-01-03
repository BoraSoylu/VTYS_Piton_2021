using Business.Abstract;
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
    public class ComplaintTypesController : ControllerBase
    {
        private readonly IComplaintTypeService complaintTypeService;

        public ComplaintTypesController(IComplaintTypeService complaintTypeService)
        {
            this.complaintTypeService = complaintTypeService;
        }

        [HttpGet("getall"), Authorize]
        public IActionResult GetAll()
        {
            var result = this.complaintTypeService.GetAllComplaintTypes();
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest();
        }


    }
}
