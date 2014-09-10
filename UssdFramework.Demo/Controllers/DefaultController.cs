﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UssdFramework.Demo.Models;

namespace UssdFramework.Demo.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly Setup _setup = new Setup("DemoApp", "localhost", Screens.All);

        [HttpPost]
        public async Task<IHttpActionResult> Index(UssdRequest ussdRequest)
        {
            var session = new Session(_setup, ussdRequest);
            return Ok(await session.AutoSetupAsync());
        }  
    }
}
