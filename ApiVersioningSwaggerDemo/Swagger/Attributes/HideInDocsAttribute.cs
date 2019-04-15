using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
using Swashbuckle.Swagger;

namespace ApiVersioningSwaggerDemo.Swagger.Attributes
{
    /// <summary>
    /// Attribute to hide certain methods in the Swagger documentation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class HideInDocsAttribute : Attribute
    {
    }
}