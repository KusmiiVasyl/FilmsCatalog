using KR.Models;

namespace KR.Interfaces
{
    public interface IFilmRepository
    {
        public List<Film> GetFilms();
        public List<Language> GetLanguages();
        public List<Category> GetCategories();
        public List<Actor> GetActors();
    }
}
