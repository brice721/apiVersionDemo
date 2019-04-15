using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace ApiVersioningSwaggerDemo.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SnippetDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static Expression<Func<Snippet, SnippetDto>> Projection
        {
            get
            {
                return x => new SnippetDto
                {
                    Title = x.Title,
                    Text = x.Text
                };
            }
        }
    }
}