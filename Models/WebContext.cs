namespace Migrations.Models
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    public class WebContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder: optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Webdb;Trusted_Connection=True");
            optionsBuilder.UseLoggerFactory(loggerFactory);
        }

        // Tạo ILoggerFactory 
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                   .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Debug)
                   .AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder: modelBuilder);
            modelBuilder.Entity<ArticleTag>(entry =>
            {
                entry.HasIndex(acticleTag => new { acticleTag.ArticleId, acticleTag.TagId })
                    .IsUnique();
            });
        }
    }
}