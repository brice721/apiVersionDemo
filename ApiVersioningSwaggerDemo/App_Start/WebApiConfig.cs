﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Web.Http;
using System.Web.Http.Routing;
using ApiVersioningSwaggerDemo.Controllers;
using Microsoft.Web.Http;
using Microsoft.Web.Http.Routing;

namespace ApiVersioningSwaggerDemo
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            var constraintResolver = new DefaultInlineConstraintResolver
            {
                ConstraintMap =
                {
                    ["apiVersion"] = typeof(ApiVersionRouteConstraint)
                }
            };

            config.AddApiVersioning(o =>
            {
                // MethodInfo methodInfo = typeof(SnippetController).GetMethod("PostV2");

                o.ReportApiVersions = true;
                // o.Conventions.Controller<SnippetController>()
                //     .HasApiVersion(ApiVersion.Parse("2"))
                //     .Action(methodInfo)
                //     .MapToApiVersion(ApiVersion.Parse("2"));
            });

            config.MapHttpAttributeRoutes(constraintResolver);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v{version}/{controller}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                }
            );
        }
    }
}
