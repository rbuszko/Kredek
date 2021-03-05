using LibraryV2.Models.Entities;
using LibraryV2.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryV2.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    class BooksRepository : Repository, IBooksRepository
    {
        /// <summary>
        /// Metoda służąca do dodania książki do bazy danych
        /// </summary>
        /// <param name="userLogin"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        /// <param name="state"></param>
        /// <param name="restriction"></param>
        /// <returns></returns>
        public bool AddBook(string userLogin, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction)
        {
            // Do sprawdzenia czy podaliśmy prawidłowe paramtery. Porównujemy podane parametry z możliwymi z bazy danych
            Genres genreOfBook = DataBaseContext.Genres.SingleOrDefault(g => g.Name == genre);
            Authors authorOfBook =
                DataBaseContext.Authors.SingleOrDefault(a => a.FirstName == authorFirstName && a.LastName == authorLastName);
            States stateOfBook = DataBaseContext.States.SingleOrDefault(s => s.Rental == state);
            Restrictions restrictionOfBook = DataBaseContext.Restrictions.SingleOrDefault(r => r.AgeLimit == restriction);
            // Sprawdzamy, czy podaliśmy poprawne parametry. Jeżeli nie to zwracamy false
            if (genreOfBook == null || authorOfBook == null || stateOfBook == null || restrictionOfBook == null)
                return false;
            // Przypisujemy parametry do nowej książki
            Books bookToAdd = new Books()
            {
                PersonName = userLogin,
                Title = title,
                Authors = authorOfBook,
                States = stateOfBook,
                Restrictions = restrictionOfBook
            };
            // Dodajemy książkę do bazy
            DataBaseContext.Books.Add(bookToAdd);
            // Jeżeli książka zostałą dodana to zwracamy true
            return DataBaseContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Metoda służąca do usunięcia książki
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public bool DeleteBook(int bookId)
        {
            // Znajdujemy obiekt do usunięcia
            Books book = DataBaseContext.Books.SingleOrDefault(b => b.Id == bookId);
            // Jeżeli nie to zwróć false
            if (book == null) return false;
            // Usunięcie użytkownika z bazy
            DataBaseContext.Books.Remove(book);
            // Jeżeli się udało, to zwróć true
            return DataBaseContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Metoda służąca do edycji książki
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="personName"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        /// <param name="state"></param>
        /// <param name="restriction"></param>
        /// <returns></returns>
        public bool EditBook(int bookId, string personName, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction)
        {
            // Znajdujemy obiekt do edycji
            Books book = DataBaseContext.Books.SingleOrDefault(b => b.Id == bookId);
            // Do sprawdzenia czy podaliśmy prawidłowe paramtery. Porównujemy podane parametry z możliwymi z bazy danych
            Genres genreOfBook = DataBaseContext.Genres.SingleOrDefault(g => g.Name == genre);
            Authors authorOfBook =
                DataBaseContext.Authors.SingleOrDefault(a => a.FirstName == authorFirstName && a.LastName == authorLastName);
            States stateOfBook = DataBaseContext.States.SingleOrDefault(s => s.Rental == state);
            Restrictions restrictionOfBook = DataBaseContext.Restrictions.SingleOrDefault(r => r.AgeLimit == restriction);
            // Sprawdzamy, czy podaliśmy poprawne parametry. Jeżeli nie to zwracamy false
            if (book == null || genreOfBook == null || authorOfBook == null || stateOfBook == null || restrictionOfBook == null)
                return false;
            //zmieniamy właściwości obiektu
            book.PersonName = personName;
            book.Title = title;
            book.Genres = genreOfBook;
            book.Authors = authorOfBook;
            book.States = stateOfBook;
            book.Restrictions = restrictionOfBook;
            // Jeżeli książka została zmieniona to zwracamy true
            return DataBaseContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Metoda służąca do pobrania listy książek
        /// </summary>
        /// <returns></returns>
        public List<BooksViewModel> GetBooks() {
            List<Books> books = DataBaseContext.Books.ToList();
            return Mapper.Map<List<Books>, List<BooksViewModel>>(books);
        }
        /// <summary>
        /// Metoda służąca do pobrania listy książek, do których użytkownik ma dostęp
        /// </summary>
        /// <returns></returns>
        public List<BooksViewModel> GetBooksToRent()
        {
            List<Books> books = DataBaseContext.Books.Where(b => b.PersonName == null).ToList();
            return Mapper.Map<List<Books>, List<BooksViewModel>>(books);
        }
        /// <summary>
        /// Metoda służąca do pobrania listy książek, którą użytkownik posiada
        /// </summary>
        /// <returns></returns>
        public List<BooksViewModel> GetUserBooks()
        {
            List<Books> books = DataBaseContext.Books.Where(b => b.PersonName == Program.user).ToList();
                       return Mapper.Map<List<Books>, List<BooksViewModel>>(books);
        }
        /// <summary>
        /// Funkcja służąca do wypożyczenia książki przez klienta
        /// </summary>
        /// <param name="Id"></param>
        public bool LendBook(int bookId)
        {
            // Znajdujemy obiekt do wypożyczenia
            Books book = DataBaseContext.Books.SingleOrDefault(b => b.Id == bookId);
            States stateOfBook = DataBaseContext.States.SingleOrDefault(s => s.Rental == "Tak");
            // Sprawdzamy wiek użytkownika
            Users user = DataBaseContext.Users.Where(u => u.Login == Program.user).FirstOrDefault();
            // Jeżeli użytkownik jest za młody
            try
            {
                if (book.Restrictions.AgeLimit == "Tak" && user.Identities.Age < 18)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
            }
            // Sprawdzamy, czy podaliśmy poprawne parametry. Jeżeli nie to zwracamy false
            if (book == null || stateOfBook == null)
                return false;
            // Przypisujemy odpowiednie wartości
            book.PersonName = Program.user;
            book.States = stateOfBook;
            // Jeżeli książka została zmieniona to zwracamy true
            return DataBaseContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Funkcja służąca do oddania książki przez klienta
        /// </summary>
        /// <param name="Id"></param>
        public bool ReturnBook(int bookId)
        {
            // Znajdujemy obiekt do wypożyczenia
            Books book = DataBaseContext.Books.SingleOrDefault(b => b.Id == bookId);
            States stateOfBook = DataBaseContext.States.SingleOrDefault(s => s.Rental == "Nie");
            // Sprawdzamy, czy podaliśmy poprawne parametry. Jeżeli nie to zwracamy false
            if (book == null || stateOfBook == null)
                return false;
            // Przypisujemy odpowiednie wartości
            book.PersonName = null;
            book.States = stateOfBook;
            // Jeżeli książka została zmieniona to zwracamy true
            return DataBaseContext.SaveChanges() > 0;
        }
    }
}
