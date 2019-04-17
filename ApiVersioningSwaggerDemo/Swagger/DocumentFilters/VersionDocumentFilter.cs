using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace ApiVersioningSwaggerDemo.Swagger.DocumentFilters
{
    public class VersionDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths = swaggerDoc.paths
                .ToDictionary(
                    path => path.Key.Replace("v{version}", swaggerDoc.info.version),
                    path => path.Value
                );
        }
    }
}