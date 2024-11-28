﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity_Donation_Mid_Exam_.Auth
{
    public class Logged: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = httpContext.Session["user"];
            if (user != null)
            {
                return true;
            }
            return false;

        }
    }
}