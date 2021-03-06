﻿using System;

namespace ApiVersioningSwaggerDemo.Swagger.Attributes
{
    /// <summary>
    /// SwaggerResponseContentTypeAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class SwaggerResponseContentTypeAttribute : Attribute
    {
        /// <summary>
        /// SwaggerResponseContentTypeAttribute
        /// </summary>
        /// <param name="responseType"></param>
        public SwaggerResponseContentTypeAttribute(string responseType)
        {
            ResponseType = responseType;
        }
        /// <summary>
        /// Response Content Type
        /// </summary>
        public string ResponseType { get; private set; }

        /// <summary>
        /// Remove all other Response Content Types
        /// </summary>
        public bool Exclusive { get; set; }
    }
}