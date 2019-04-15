using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
using ApiVersioningSwaggerDemo.Swagger.Attributes;
using Swashbuckle.Swagger;

namespace ApiVersioningSwaggerDemo.Swagger.DocumentFilters
{
    /// <summary>
    /// Filter to hide methods from Swagger documentation.
    /// </summary>
    public class HideInDocsDocumentFilter : IDocumentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiExplorer"></param>
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            foreach (var apiDescription in apiExplorer.ApiDescriptions)
            {
                if (!apiDescription.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<HideInDocsAttribute>().Any() &&
                    !apiDescription.ActionDescriptor.GetCustomAttributes<HideInDocsAttribute>().Any()) continue;
                var route = "/" + apiDescription.Route.RouteTemplate.TrimEnd('/');
                swaggerDoc.paths.Remove(route);
            }
        }
    }
}