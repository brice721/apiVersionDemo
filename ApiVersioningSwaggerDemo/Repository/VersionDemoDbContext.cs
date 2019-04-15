using ApiVersioningSwaggerDemo.Models;

namespace ApiVersioningSwaggerDemo.Repository
{
    using System.Data.Entity;

    /// <summary>
    /// 
    /// </summary>
    public class VersionDemoDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public VersionDemoDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<VersionDemoDbContext>(new 
                CreateDatabaseIfNotExists<VersionDemoDbContext>());
        }

        /// <summary>
        /// Snippet entity
        /// </summary>
        public virtual DbSet<Snippet> Snippets { get; set; }
    }
}