using LibraryV2.Models.Entities;
using System.Collections.Generic;

namespace LibraryV2.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    interface IBooksRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda do pobrania wszystkich książek z tabeli Books
        /// </summary>
        /// <returns></returns>
        List<BooksViewModel> GetBooks();
        //List<Books> GetBooks();
        /// <summary>
        /// Abstrakcyjna metoda do pobrania książek, do których klient ma dostęp
        /// </summary>
        /// <returns></returns>
        List<BooksViewModel> GetBooksToRent();
        /// <summary>
        /// Abstrakcyjna metoda do pobrania książek, które klient posiada
        /// </summary>
        /// <returns></returns>
        List<BooksViewModel> GetUserBooks();
        /// <summary>
        /// Abstrakcyjna metoda do dodawania nowej książki do tabeli Books
        /// </summary>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        bool AddBook(string userLogin, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction);
        /// <summary>
        /// Abstrakcyjna metoda do usuwania książki z tabeli Books na podstawie bookId
        /// </summary>
        /// <param name="bookId"></param>
        bool DeleteBook(int bookId);
        /// <summary>
        /// Abstrakcyjna metoda do aktualizacji książki z tabeli Books
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        bool EditBook(int bookId, string personName, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction);
        /// <summary>
        /// Abstrakcyjna metoda używana w kliencie, służy zasymulowaniu pożyczenia ksiażki
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="Id"></param>
        bool LendBook(int bookId);
        /// <summary>
        /// Abstrakcyjna metoda używana w kliencie, służy zasymulowaniu oddania książki
        /// </summary>
        /// <param name="Id"></param>
        bool ReturnBook(int bookId);
    }
}
