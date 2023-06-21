using KR.Models;
using Microsoft.EntityFrameworkCore;

namespace KR.Repositories
{
    public class SakilaDbContext : DbContext
    {
        public SakilaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmActor> FilmsActors { get; set; }
        public DbSet<FilmCategory> FilmsCategories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().ToTable("film", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<Actor>().ToTable("actor", a => a.ExcludeFromMigrations());
            modelBuilder.Entity<FilmActor>().ToTable("film_actor", fa => fa.ExcludeFromMigrations()).HasNoKey();
            modelBuilder.Entity<Language>().ToTable("language", l => l.ExcludeFromMigrations());
            modelBuilder.Entity<Category>().ToTable("category", c => c.ExcludeFromMigrations());
            modelBuilder.Entity<FilmCategory>().ToTable("film_category", fc => fc.ExcludeFromMigrations()).HasNoKey();
        }
    }
}
