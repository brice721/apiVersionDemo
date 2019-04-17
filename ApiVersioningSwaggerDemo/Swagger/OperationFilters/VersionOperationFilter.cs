using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using Swashbuckle.Swagger;
using System.Web.Http.Description;

namespace ApiVersioningSwaggerDemo.Swagger.OperationFilters
{
    public class VersionOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            var version = operation.parameters?.FirstOrDefault(p => p.name == "version");
            if (version != null)
            {
                operation.parameters.Remove(version);
            }
        }
    }
}