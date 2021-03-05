using AutoMapper;
using LibraryV2.Infrastructure;
using LibraryV2.Models;

namespace LibraryV2.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public abstract class Repository
    {
        // Zmienna przechowująca konktekst bazy danych
        protected readonly DataBaseContext DataBaseContext = new DataBaseContext();
        // Zmienna konfiguracji
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        // zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
