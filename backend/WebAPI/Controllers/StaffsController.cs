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
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService staffService;

        public StaffsController(IStaffService staffService)
        {
            this.staffService = staffService;
        }

        [HttpGet("alldata"), Authorize(Roles = "Citizen")]
        public IActionResult GetAllStaffs()
        {
            var result = this.staffService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }



    }
}
