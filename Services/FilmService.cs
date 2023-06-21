using KR.Interfaces;
using KR.Models;

namespace KR.Services
{

    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public List<Film> GetFilms()
        {
            return _filmRepository.GetFilms();
        }

        public List<Language> GetLanguages()
        {
            return _filmRepository.GetLanguages();
        }

        public List<Category> GetCategories()
        {
            return _filmRepository.GetCategories();
        }

        public List<Actor> GetActors()
        {
            return _filmRepository.GetActors();
        }
    }
}
