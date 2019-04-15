namespace ApiVersioningSwaggerDemo.Controllers
{
    using Models;
    using System.Web.Http;
    using Swagger.Attributes;
    using Microsoft.Web.Http;

    /// <summary>
    /// Version two of the Notes Controller
    /// </summary>
    [ApiVersion("2")]
    [ControllerName("Snippet")]
    [RoutePrefix("api/v{version:apiVersion}/snippet")]
    public class Snippet2Controller : ApiController
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public Snippet2Controller()
        {

        }

        /// <summary>
        /// Second Snippet Controller.
        /// </summary>
        /// <returns></returns>
        [SwaggerResponseContentType(responseType: "application/json", Exclusive = true)]
        public Snippet Get() => 
            new Snippet
            {
                Id = 1,
                Title = "Test Snippet",
                Text = "Testing data for snippet controller number two."
            };
    }
}
