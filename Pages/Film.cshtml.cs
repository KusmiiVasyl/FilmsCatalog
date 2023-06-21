using KR.Models;
using KR.Repositories;
using KR.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KR.Pages
{
    public class FilmModel : PageModel
    {
        private readonly IFilmService _filmService;

        public List<Film> Films { get; set; }
        public List<Language> Languages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Actor> Actors { get; set; }
        public string SelectedActor { get; set; } = "";
        public string SelectedCategory { get; set; } = "";
        public string SelectedLanguage { get; set; } = "";

        public FilmModel(IFilmService filmService)
        {
            _filmService = filmService;
        }

        public void OnGet()
        {
            Films = _filmService.GetFilms();
            Languages = _filmService.GetLanguages();
            Categories = _filmService.GetCategories();
            Actors = _filmService.GetActors();
        }

        public IActionResult OnPostFilmsFilter(string actor, string language, string categorie)
        {
            Films = _filmService.GetFilms();
            Languages = _filmService.GetLanguages();
            Categories = _filmService.GetCategories();
            Actors = _filmService.GetActors();

            if (!string.IsNullOrEmpty(actor))
            {
                string[] actorParse = actor.Split(' ');
                string firstName = actorParse[0];
                string lastName = actorParse[1];

                Films = Films.Where(f => f.Actors
                    .Any(a => a.FirstName == firstName && a.LastName == lastName))
                    .ToList();
            }

            if (!string.IsNullOrEmpty(language))
            {
                Films = Films.Where(f => f.Languages
                    .Any(l => l.Name == language))
                    .ToList();
            }

            if (!string.IsNullOrEmpty(categorie))
            {
                Films = Films.Where(f => f.Categories
                    .Any(c => c.Name == categorie))
                    .ToList();
            }

            SelectedActor = actor;
            SelectedLanguage = language;
            SelectedCategory = categorie;

            return Page();
        }

    }
}
