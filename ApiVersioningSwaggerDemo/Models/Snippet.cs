using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace ApiVersioningSwaggerDemo.Models
{
    /// <summary>
    /// Model for saving chunks of code or text notes that you don't want to forget.
    /// </summary>
    [Table("Snippets")]
    public class Snippet
    {
        /// <summary>
        /// Id for the code or text snippet.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The title of the code or text snippet.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The code or text snippet.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static Expression<Func<SnippetDto, Snippet>> Projection
        {
            get
            {
                return x => new Snippet
                {
                    Title = x.Title,
                    Text = x.Text
                };
            }
        }
    }
}