﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        // SignUp method
        [HttpPost]
        public ActionResult SignUp([FromBody] Register signupData)
        {
            // TODO signup sequence
            return new StatusCodeResult(StatusCodes.Status201Created);
        }

        // Edit method
        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Register accountData)
        {
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        // Remove method
        [HttpDelete("{id}")]
        public ActionResult Remove()
        {
            return new StatusCodeResult(StatusCodes.Status404NotFound);
        }

        // 
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return Ok(new Account
            {
                Username = id,
                AccessLevel = 0,
                Email = id + "@mail.com",
                FirstName = "Johnny",
                LastName = "Test"
            });
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new List<Account> { new Account { Username = "Test" }, new Account { Username = "Test2" } });
        }

    }
}