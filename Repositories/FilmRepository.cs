using KR.Interfaces;
using KR.Models;
using Microsoft.EntityFrameworkCore;

namespace KR.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly SakilaDbContext _dbContext;
        private List<Film> _films;
        private List<Actor> _actors;
        private List<FilmActor> _filmsActors;
        private List<Category> _categories;
        private List<FilmCategory> _filmCategories;
        private List<Language> _languages;

        public FilmRepository(SakilaDbContext dbContext)
        {
            _dbContext = dbContext;

            _actors = _dbContext.Actors.ToList();
            _films = _dbContext.Films.Take(200).ToList();
            _filmsActors = _dbContext.FilmsActors.ToList();
            _categories = _dbContext.Categories.ToList();
            _filmCategories = _dbContext.FilmsCategories.ToList();
            _languages = _dbContext.Languages.ToList();
        }

        public List<Film> GetFilms()
        {
            foreach (var film in _films)
            {
                film.Actors = new List<Actor>();
                film.Categories = new List<Category>();
                film.Languages = new List<Language>();

                film.Actors = _actors
                    .Where(a => _filmsActors.Any(fa => fa.FilmId == film.FilmId && fa.ActorId == a.ActorId))
                    .ToList();
                film.Categories = _categories
                    .Where(c => _filmCategories.Any(fc => fc.FilmId == film.FilmId && fc.CategoryId == c.CategoryId))
                    .ToList();
                film.Languages = _languages
                    .Where(l => l.LanguageId == film.LanguageId)
                    .ToList();
            }

            return _films;
        }

        public List<Language> GetLanguages() => _languages;
        public List<Category> GetCategories() => _categories;
        public List<Actor> GetActors() => _actors;

    }
}
