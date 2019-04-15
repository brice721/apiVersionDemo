using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiVersioningSwaggerDemo
{
    /// <summary>
    /// Application constants.
    /// </summary>
    public class AppConstants
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ApiDescription = "Generic Description.";

        /// <summary>
        /// 
        /// </summary>
        public const string ApiContactName = "Brandon Rice";

        /// <summary>
        /// 
        /// </summary>
        public const string ApiContactUrl = "https://meijer.com";

        /// <summary>
        /// 
        /// </summary>
        public const string ApiContactEmail = "brandon.rice@meijer.com";

        /// <summary>
        /// 
        /// </summary>
        public static string ContentRootPath
        {
            get
            {
                var app = AppDomain.CurrentDomain;

                if (string.IsNullOrEmpty(app.RelativeSearchPath))
                {
                    return app.BaseDirectory;
                }

                return app.RelativeSearchPath;
            }
        }

        static string XmlCommentsFilePath => 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\ApiVersioningSwaggerDemo.xml");
    }
}