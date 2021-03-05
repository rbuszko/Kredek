using System.Data;

namespace Library.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    interface IBooksRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda do pobierania wszystkich książek z tabeli Books
        /// </summary>
        /// <returns></returns>
        DataTable GetBooks(int option, string name);

        /// <summary>
        /// Abstrakcyjna metoda do dodawania nowej książki do tabeli Books
        /// </summary>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        void AddBook(string personName, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction);
        /// <summary>
        /// Abstrakcyjna metoda używana w kliencie, służy zasymulowaniu pożyczenia ksiażki
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="Id"></param>
        void LendBook(string FirstName, int Id);
        /// <summary>
        /// Abstrakcyjna metoda używana w kliencie, służy zasymulowaniu oddania książki
        /// </summary>
        /// <param name="Id"></param>
        void ReturnBook(int Id);
        /// <summary>
        /// Abstrakcyjna metoda do usuwania książki z tabeli Books na podstawie bookId
        /// </summary>
        /// <param name="bookId"></param>
        void DeleteBook(int bookId);

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
        void EditBook(int bookId, string personName, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction);
    }
}
