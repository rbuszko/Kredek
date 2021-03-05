using System;
using System.Data;
using System.Data.SqlClient;
using Library.Repositories.Interfaces;

namespace Library.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    class BooksRepository : Repository, IBooksRepository
    {
        /// <summary>
        /// Metoda dodająca książkę do bazy danych
        /// </summary>
        /// <param name="personName"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        /// <param name="state"></param>
        /// <param name="restriction"></param>
        public void AddBook(string personName, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction)
        {
            // Zapytania w celu zdobycia dostępu do kluczy obcych tabeli książki
            string queryGetAuthorId = "SELECT Id FROM Authors WHERE FirstName='" + authorFirstName + "' AND LastName='" + authorLastName + "';";
            string queryGetGenreId = "SELECT Id FROM Genres WHERE Name='" + genre + "';";
            string queryGetStateId = "SELECT Id FROM States WHERE Rental='" + state + "';";
            string queryGetRestrictionId = "SELECT Id FROM Restriction WHERE AgeLimit='" + restriction + "';";
            // Otwarcie łącza
            Connection.Open();
            // Pobranie i przypisanie kluczy obcych tabeli książki
            SqlCommand commandGetGenreId = new SqlCommand(queryGetGenreId, Connection);
            int genreId = (int)commandGetGenreId.ExecuteScalar();
            SqlCommand commandGetAuthorId = new SqlCommand(queryGetAuthorId, Connection);
            int authorId = (int)commandGetAuthorId.ExecuteScalar();
            SqlCommand commandGetStateId = new SqlCommand(queryGetStateId, Connection);
            int stateId = (int)commandGetStateId.ExecuteScalar();
            SqlCommand commandGetRestrictionId = new SqlCommand(queryGetRestrictionId, Connection);
            int restrictionId = (int)commandGetRestrictionId.ExecuteScalar();
            // Zapytanie w celu dodania książki
            string insertBookQuery = "INSERT INTO Books VALUES ('" + personName + "','" + title + "'," + genreId + "," + authorId + "," + stateId + "," + restrictionId + ");";
            // Wysłanie polecenia przez łącze
            SqlCommand commandInsertBook = new SqlCommand(insertBookQuery, Connection);
            commandInsertBook.ExecuteNonQuery();
            // Zamknięcie łącza
            Connection.Close();
        }
        /// <summary>
        /// Metoda usuwająca książkę po Id książki
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBook(int bookId)
        {
            // Zapytanie w celu usunięcia książki po Id
            string queryDeleteBook = $"DELETE FROM Books WHERE Id= {bookId};";
            // Otwarcie łącza
            Connection.Open();
            // Wysłanie zapytania
            SqlCommand commandDeleteBook = new SqlCommand(queryDeleteBook, Connection);
            commandDeleteBook.ExecuteScalar();
            // Zamknięcie łącza
            Connection.Close();
        }
        /// <summary>
        /// Metoda służąca edytowaniu książki
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="personName"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        /// <param name="state"></param>
        /// <param name="restriction"></param>
        public void EditBook(int bookId, string personName, string title, string genre, string authorFirstName, string authorLastName, string state, string restriction)
        {
            // Zapytania w celu pozyskania kluczy obcych tabeli książki
            string queryGetAuthorId = "SELECT Id FROM Authors WHERE FirstName='" + authorFirstName + "' AND LastName='" + authorLastName + "';";
            string queryGetGenreId = "SELECT Id FROM Genres WHERE Name='" + genre + "';";
            string queryGetStateId = "SELECT Id FROM States WHERE Rental='" + state + "';";
            string queryGetRestrictionId = "SELECT Id FROM Restriction WHERE AgeLimit='" + restriction + "';";
            // Otwarcie łącza
            Connection.Open();
            // Pobranie i przypisanie wartości kluczy obcych tabeli książki
            SqlCommand commandGetGenreId = new SqlCommand(queryGetGenreId, Connection);
            int genreId = (int)commandGetGenreId.ExecuteScalar();
            SqlCommand commandGetAuthorId = new SqlCommand(queryGetAuthorId, Connection);
            int authorId = (int)commandGetAuthorId.ExecuteScalar();
            SqlCommand commandGetStateId = new SqlCommand(queryGetStateId, Connection);
            int stateId = (int)commandGetStateId.ExecuteScalar();
            SqlCommand commandGetRestrictionId = new SqlCommand(queryGetRestrictionId, Connection);
            int restrictionId = (int)commandGetRestrictionId.ExecuteScalar();
            // Zapytanie w celu zmiany danych konkretnej książki po Id książki
            string insertBookQuery = "Update Books SET " +
                "PersonName='" + personName + "'," +
                "Title='" + title + "'," + 
                "GenresId=" + genreId + "," +
                "AuthorsId=" + authorId + "," +
                "StatesId=" + stateId + "," + 
                "RestrictionId=" + restrictionId + "" +
                "WHERE Id=" + bookId + ";";
            // Wysłanie polecenia edytowania książki przez łącze
            SqlCommand commandInsertBook = new SqlCommand(insertBookQuery, Connection);
            commandInsertBook.ExecuteNonQuery();
            // Zamknięcie łącza
            Connection.Close();
        }
        /// <summary>
        /// Metoda służąca pożyczeniu książki
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="Id"></param>
        public void LendBook(string FirstName, int Id)
        {
            // Zapytanie służące pobraniu Id tabeli states odpowiadającego za status wypożyczony
            string queryGetStateId = "SELECT Id FROM States WHERE Rental='Wypożyczony';";
            // Otwarcie łącza
            Connection.Open();
            // Pobranie wartości klucza Id odpowiadającego za status wypożyczony
            SqlCommand commandGetStateId = new SqlCommand(queryGetStateId, Connection);
            int stateId = (int)commandGetStateId.ExecuteScalar();
            // Przypisanie użytkownika do wypożyczonej książki po Id książki i zmiana statusu
            string lendBookQuery = $"Update Books SET PersonName = '{FirstName}', StatesId = {stateId} WHERE Books.Id ={Id};";
            SqlCommand commandlendBook = new SqlCommand(lendBookQuery, Connection);
            commandlendBook.ExecuteNonQuery();
            // Zamknięcie łącza
            Connection.Close();
        }
        /// <summary>
        /// Metoda służąca zwróceniu książki
        /// </summary>
        /// <param name="Id"></param>
        public void ReturnBook(int Id)
        {
            // Zapytanie służące pobraniu Id tabeli states odpowiadającego za status wolny
            string queryGetStateId = "SELECT Id FROM States WHERE Rental='Wolny';";
            // Otwarcie łącza
            Connection.Open();
            SqlCommand commandGetStateId = new SqlCommand(queryGetStateId, Connection);
            int stateId = (int)commandGetStateId.ExecuteScalar();
            // Przypisanie pustego pola do miejsca użytkownika posiadającego książkę po Id książki i zmiana statusu
            string returnBookQuery = $"Update Books SET PersonName = '', StatesId = {stateId} WHERE Books.Id ={Id};";
            SqlCommand commandreturnBook = new SqlCommand(returnBookQuery, Connection);
            commandreturnBook.ExecuteNonQuery();
            // Zamknięcie łącza
            Connection.Close();
        }
        /// <summary>
        /// Metoda zwracająca książki z tabeli books
        /// Jeżeli option = 1, GetBooks dla pracownika, zwraca wszystko
        /// Jeżeli option = 2, GetBooks dla osoby młodszej uwzględnia restrykcje wieku
        /// Jeżeli option = 3, GetBooks dla osoby starszej powyżej 18 lat 
        /// Jeżeli option = 4, pokazuje ksiażki, które dana osoba ma wypożyczone
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public DataTable GetBooks(int option, string name)
        {
            string getBooksQuery;
            if (option == 1)
            {
                getBooksQuery = $"SELECT Books.*, Genres.Name, Authors.FirstName, Authors.LastName," +
                    $" States.Rental, Restriction.AgeLimit FROM Books" +
                    $" JOIN Genres ON Books.GenresId = Genres.Id" +
                    $" JOIN Authors ON Books.AuthorsiD = Authors.Id" +
                    $" JOIN States ON Books.StatesId = States.Id" +
                    $" JOIN Restriction ON Books.RestrictionId = Restriction.Id;";
            }
            else if (option == 2)
            {
                getBooksQuery = "SELECT Books.*, Genres.Name, Authors.FirstName, Authors.LastName," +
                    " States.Rental, Restriction.AgeLimit FROM Books" +
                    " JOIN Genres ON Books.GenresId = Genres.Id" +
                    " JOIN Authors ON Books.AuthorsiD = Authors.Id" +
                    " JOIN States ON Books.StatesId = States.Id" +
                    " JOIN Restriction ON Books.RestrictionId = Restriction.Id" +
                    " WHERE States.Rental = 'Wolny' AND Restriction.AgeLimit = 'Nie';";
            }
            else if (option == 3)
            {
                getBooksQuery = "SELECT Books.*, Genres.Name, Authors.FirstName, Authors.LastName," +
                    " States.Rental, Restriction.AgeLimit FROM Books" +
                    " JOIN Genres ON Books.GenresId = Genres.Id" +
                    " JOIN Authors ON Books.AuthorsiD = Authors.Id" +
                    " JOIN States ON Books.StatesId = States.Id" +
                    " JOIN Restriction ON Books.RestrictionId = Restriction.Id" +
                    " WHERE States.Rental = 'Wolny';";
            }
            else
            {
                getBooksQuery = $"SELECT Books.*, Genres.Name, Authors.FirstName, Authors.LastName," +
                    $" States.Rental, Restriction.AgeLimit FROM Books" +
                    $" JOIN Genres ON Books.GenresId = Genres.Id" +
                    $" JOIN Authors ON Books.AuthorsiD = Authors.Id" +
                    $" JOIN States ON Books.StatesId = States.Id" +
                    $" JOIN Restriction ON Books.RestrictionId = Restriction.Id" +
                    $" WHERE PersonName = '{name}';";
            }
            // Wypełnienie tabeli 
            SqlDataAdapter adapter = new SqlDataAdapter(getBooksQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
