﻿using SimpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(PostsController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" },namespaces);
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "login" },namespaces);
            routes.MapRoute("Register", "register", new { controller = "Register", action = "Register" }, namespaces);


        }
    }
}
