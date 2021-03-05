using LibraryV2.Models.Entities;
using LibraryV2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryV2.Forms
{
    public partial class FormWorker : Form
    {
        // Obiekt repozytorium użytkownika
        private BooksRepository booksRepository = new BooksRepository();

        public FormWorker()
        {
            InitializeComponent();

            // Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Funkcja służąca do odświeżenia dataGridViewUsers
        /// </summary>
        private void RefreshDataGridViewBooks()
        {
            dataGridViewBooks.DataSource = booksRepository.GetBooks();
        }
        /// <summary>
        /// Funkcja służy do wyczyszczenia wszystkich TextBoxów
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
            textBoxUser.Text = "";
            textBoxTitle.Text = "";
            textBoxGenre.Text = "";
            textBoxAuthorsFirstName.Text = "";
            textBoxAuthorsLastName.Text = "";
            textBoxState.Text = "";
            textBoxRestriction.Text = "";
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku dodania nowej książki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // Pobranie parametrów użytkownika z tabel
            string user = textBoxUser.Text;
            string title = textBoxTitle.Text;
            string genre = textBoxGenre.Text;
            string authorsFirstName = textBoxAuthorsFirstName.Text;
            string authorsLastName = textBoxAuthorsLastName.Text;
            string state = textBoxState.Text;
            string restriction = textBoxRestriction.Text;

            // Dodanie książki
            bool isAdded = booksRepository.AddBook(user, title, genre, authorsFirstName, authorsLastName, state, restriction);
            // Jeżeli książka została dodana 
            if (isAdded)
            {
                // Odświeżamy tabelę
                RefreshDataGridViewBooks();
                // Czyścimy okienka
                ClearTextBoxes();
            }
            // Jeżeli nie, to wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Książka nie została dodana sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do usuwania książki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            // Pobranie id książki
            int id = int.Parse(textBoxId.Text);
            // Usunięcie książki z bazy
            bool isDeleted = booksRepository.DeleteBook(id);
            // Jeżeli książka została usunięta
            if (isDeleted)
            {
                // Odświeżamy tabelę użytkownika
                RefreshDataGridViewBooks();
                // Czyścimy textboxy
                ClearTextBoxes();
            }
            // Jeżeli nie został, wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Ksiązka nie została usunięta sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku edytowania książki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            // Pobranie danych z textboxów
            int id = int.Parse(textBoxId.Text);
            string user = textBoxUser.Text;
            string title = textBoxTitle.Text;
            string genre = textBoxGenre.Text;
            string authorsFirstName = textBoxAuthorsFirstName.Text;
            string authorsLastName = textBoxAuthorsLastName.Text;
            string state = textBoxState.Text;
            string restriction = textBoxRestriction.Text;

            // Wysłanie zapytania edytującego dane książki
            bool isEdited = booksRepository.EditBook(id, user, title, genre, authorsFirstName, authorsLastName, state, restriction);
            // Jeżeli książka została edytowana
            if (isEdited)
            {
                // Odświeżamy tabelę
                RefreshDataGridViewBooks();
                // Czyścimy textboxy
                ClearTextBoxes();
            }
            // Jeżeli nie to wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Ksiązka nie została edytowana sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza w DataGridViewBooks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            // Pobieramy dane wybranego użytkownika
            BooksViewModel book = (BooksViewModel)dataGridViewBooks.CurrentRow.DataBoundItem;

            //nadpisz dane zaznaczonym rekordem
            textBoxId.Text = book.Id.ToString();
            try
            {
                textBoxUser.Text = book.PersonName.ToString();
            }
            catch (Exception ex)
            {
                textBoxUser.Text = null;
            }
            textBoxTitle.Text = book.Title.ToString();
            textBoxGenre.Text = book.Genre;
            textBoxAuthorsFirstName.Text = book.AuthorFirstName;
            textBoxAuthorsLastName.Text = book.AuthorLastName;
            textBoxState.Text = book.State;
            textBoxRestriction.Text = book.Restriction;
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewBooks();
        }
    }
}
