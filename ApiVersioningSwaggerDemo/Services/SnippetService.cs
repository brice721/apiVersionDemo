using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ApiVersioningSwaggerDemo.Models;
using ApiVersioningSwaggerDemo.Repository;

namespace ApiVersioningSwaggerDemo.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class SnippetService
    {
        readonly VersionDemoDbContext _context = new VersionDemoDbContext();

        /// <summary>
        /// CTOR
        /// </summary>
        public SnippetService()
        {
        }

        /// <summary>
        /// Gets all saved snippets.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SnippetDto> GetSnippets() =>
            _context.Snippets.Select(SnippetDto.Projection).ToList();

        /// <summary>
        /// Saves a code or text snippet.
        /// </summary>
        /// <param name="snippet"></param>
        /// <returns></returns>
        public IEnumerable<SnippetDto> PostSnippet(Snippet snippet)
        {
            try
            {
                _context.Snippets.Add(snippet);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return GetSnippets();
        }

        /// <summary>
        /// Gets Snippet by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Snippet GetSnippetById(int id) => 
            _context.Snippets.Find(id);

        /// <summary>
        /// Update a snippet.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public IEnumerable<SnippetDto> UpdateSnippet(int id, Snippet entity)
        {
            var snippet = _context.Snippets.Find(id);

            if (snippet != null)
            {
                snippet.Title = entity.Title;
                snippet.Text = entity.Text;
            }

            _context.SaveChanges();

            return GetSnippets();
        }

        /// <summary>
        /// Delete snippet
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<SnippetDto> DeleteSnippet(int id)
        {
            var snippet = _context.Snippets.Find(id);
            _context.Entry(snippet).State = EntityState.Deleted;
            _context.SaveChanges();

            return GetSnippets();
        }
    }
}