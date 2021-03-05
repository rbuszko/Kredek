using LibraryV2.Models.Entities;
using LibraryV2.ViewModels;
using System.Collections.Generic;

namespace LibraryV2.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    interface IUsersRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda do pobrania wszystkich użytkowników z tabeli Users
        /// </summary>
        /// <returns></returns>
        List<UsersViewModel> GetUsers();
        /// <summary>
        /// Abstrakcyjna metoda do pobrania wszystkich danych osobowych z tabeli Identities
        /// </summary>
        /// <returns></returns>
        List<Identities> GetIdentities();
        /// <summary>
        /// Funkcja służąca do dodania osoby do tabeli Identities
        /// </summary>
        /// <returns></returns>
        bool AddIdentity(string firstName, string lastName, int age, byte[] image);
        /// <summary>
        /// Abstrakcyjna metoda do dodania nowego użytkownika do tabeli Users
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="personId"></param>
        /// <returns></returns>
        bool AddUser(string login, string password, int personId, string role);
        /// <summary>
        /// Abstrakcyjna metoda do usunięcia użytkownika z tabeli Users
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool DeleteUser(int userId);
        /// <summary>
        /// Abstrakcyjna metoda do edytowania użytkownika znajdującego się w tabeli Users
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="personId"></param>
        /// <returns></returns>
        bool EditUser(int userId, string login, string password, int personId, string role);
        /// <summary>
        /// Abstrakcyjna metoda do sprawdzenia czy użytkownik istnieje w bazie
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="who"></param>
        /// <returns></returns>
        bool CheckUser(string login, string password, string who);
    }
}
