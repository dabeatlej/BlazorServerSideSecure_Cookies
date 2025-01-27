﻿using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DummyEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(new[] { new Employee()
                    { EmployeeId = 123,
                    FirstName = "Clint",
                    LastName = "Baker",
                    Email = "CQ_RunTings@gmail.com" }});
        }
    }
}
