﻿namespace MvcApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;
    using Models;

    public class UserController : Controller
    {
        //
        // GET: /User/Login

        [HttpGet]
        public ActionResult Login()
        {
            return this.View();
        }
    }
}
