using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kolokwium.DTOs.Requests;
using Kolokwium.DTOs.Responses;
using Kolokwium.Models;
using Kolokwium.Services;

namespace Kolokwium.Controllers
{
    [Route("api/prescriptions")]
    [ApiController] //-> implicit model validation
    public class EnrollmentsController : ControllerBase
    {
        private IStudentDbService _service;

        public EnrollmentsController(IStudentDbService service)
        {
            _service = service;
        }

        //Zadanie 1
        [HttpGet("{id}")]
        public IActionResult EnrollStudent(int id)
        {
            var response = _service.EnrollZad1(id);
            if (response == null) return NotFound("problem");
             else return Ok(response); 
           
        }

      

    }
}