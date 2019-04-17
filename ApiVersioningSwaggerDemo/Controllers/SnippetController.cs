using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using ApiVersioningSwaggerDemo.Models;
using ApiVersioningSwaggerDemo.Services;
using ApiVersioningSwaggerDemo.Swagger.Attributes;
using Microsoft.Web.Http;
using Swashbuckle.Application;
using Swashbuckle.Swagger.Annotations;

namespace ApiVersioningSwaggerDemo.Controllers
{
    /// <summary>
    /// Version two of the Notes Controller
    /// </summary>
    [ApiVersion("1")]
    [RoutePrefix("api/v{version:apiVersion}/snippet")]
    public class SnippetController : ApiController
    {
        private readonly SnippetService _snippetService = new SnippetService();

        /// <summary>
        /// Default Get Method.
        /// </summary>
        /// <remarks>
        /// #### Snippet Controller
        /// -----
        /// </remarks>
        /// <returns cref="Snippet">Snippet</returns>
        /// <response code="404">Not Found</response>
        [HttpGet, Route]
        [ResponseType(typeof(Snippet))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(Snippet))]
        [SwaggerResponseContentType(responseType: "application/json", Exclusive = true)]
        [SwaggerResponse(HttpStatusCode.NotFound, "Not Found", Type = typeof(NotFoundResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal Server Error", Type =
            typeof(InternalServerErrorResult))]
        public IHttpActionResult Get() => 
            Ok(_snippetService.GetSnippets());

        /// <summary>
        /// Gets Snippet by id.
        /// </summary>
        /// <remarks>
        /// #### Get Snippet by Id.
        /// -----
        /// </remarks>
        /// <param name="id"></param>
        /// <returns cref="Snippet">Snippet</returns>
        [HttpGet, Route("{id:int}")]
        [ResponseType(typeof(Snippet))]
        [SwaggerResponse(HttpStatusCode.OK, "OK", Type = typeof(Snippet))]
        [SwaggerResponseContentType(responseType: "application/json", Exclusive = true)]
        [SwaggerResponse(HttpStatusCode.NotFound, "Not Found", Type = typeof(NotFoundResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal Server Error", Type = typeof(InternalServerErrorResult))]
        public IHttpActionResult GetById(int id) =>
            Ok(_snippetService.GetSnippetById(id));

        /// <summary>
        /// Posts a snippet to the database.
        /// </summary>
        /// <param name="snippet"></param>
        [HttpPost, Route]
        [ResponseType(typeof(Snippet))]
        [SwaggerResponse(HttpStatusCode.OK, "OK", Type = typeof(Snippet))]
        [SwaggerResponseContentType(responseType: "application/json", Exclusive = true)]
        [SwaggerResponse(HttpStatusCode.NotFound, "Not Found", Type = typeof(NotFoundResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal Server Error", Type = typeof(InternalServerErrorResult))]
        public IHttpActionResult Post([FromBody]Snippet snippet) =>
            Ok(_snippetService.PostSnippet(snippet));

        /// <summary>
        /// Version two of the post method.
        /// </summary>
        /// <param name="snippet"></param>
        /// <returns></returns>
        public IHttpActionResult PostV2([FromBody] Snippet snippet) =>
            Ok();

        /// <summary>
        /// Update Snippet
        /// </summary>
        /// <param name="id"></param>
        /// <param cref="Snippet" name="snippet"></param>
        [HttpPut, Route("{id:int}")]
        [ResponseType(typeof(Snippet))]
        [SwaggerResponse(HttpStatusCode.OK, "OK", Type = typeof(Snippet))]
        [SwaggerResponseContentType(responseType: "application/json", Exclusive = true)]
        [SwaggerResponse(HttpStatusCode.NotFound, "Not Found", Type = typeof(NotFoundResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal Server Error", Type = typeof(InternalServerErrorResult))]
        public IHttpActionResult Put(int id, [FromBody] Snippet snippet) =>
            Ok(_snippetService.UpdateSnippet(id, snippet));

        /// <summary>
        /// Delete Snippet
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete, Route("{id:int}")]
        [ResponseType(typeof(Snippet))]
        [SwaggerResponse(HttpStatusCode.OK, "OK", Type = typeof(Snippet))]
        [SwaggerResponseContentType(responseType: "application/json", Exclusive = true)]
        [SwaggerResponse(HttpStatusCode.NotFound, "Not Found", Type = typeof(NotFoundResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal Server Error", Type = typeof(InternalServerErrorResult))]
        public IHttpActionResult Delete(int id) =>
            Ok(_snippetService.DeleteSnippet(id));
    }
}