using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class FormWorker : Form
    {
        // Zmienne danych pracownika
        string firstName;
        string lastName;
        int age;

        UsersRepository usersRepository = new UsersRepository();
        BooksRepository booksRepository = new BooksRepository();
        public FormWorker()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja odpowiadająca za pobranie odpowiednich wartości z bazy danych
        /// i przypisanie ich do tabeli
        /// </summary>
        private void RefreshDataGridViewBooks()
        {
            DataTable booksToLend = booksRepository.GetBooks(1, "Brak");

            // przypisz przypisz książki do wypożyczenia do DataGridView
            dataGridViewBooks.DataSource = booksToLend;
        }
        
        private void FormWorker_Load(object sender, EventArgs e)
        {
            // Przypisanie danych osobowych pracownika
            usersRepository.AssignIdentity(ref firstName, ref lastName, ref age);
            // Wyświetlenie danych pracownika
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
            textBoxAge.Text = age.ToString();
            textBoxRole.Text = Program.Role;
            // Odświeżenie danych
            RefreshDataGridViewBooks();
        }
        /// <summary>
        /// Przycisk odpowiadający za dodanie książki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // Pobranie odpowiednich wartości wpisanych przez użytkownika
            string personName = textBoxPersonName.Text;
            string title = textBoxTitle.Text;
            string genre = textBoxGenre.Text;
            string authorsFirstName = textBoxAuthorFirstName.Text;
            string authorsLastName = textBoxAuthorLastName.Text;
            string state = textBoxState.Text;
            string restriction = textBoxRestriction.Text;
            // Funkcja dodająca książke do bazy
            booksRepository.AddBook(personName, title, genre, authorsFirstName, authorsLastName, state, restriction);
            // Odświeżenie tabel
            RefreshDataGridViewBooks();
            // Wyczyszczenie okien
            ClearTextBoxes();
        }

        /// <summary>
        /// Metoda czyszcząca wszystkie TextBoxy w oknie głównym
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxPersonName.Text = "";
            textBoxTitle.Text = "";
            textBoxGenre.Text = "";
            textBoxAuthorFirstName.Text = "";
            textBoxAuthorLastName.Text = "";
            textBoxState.Text = "";
            textBoxRestriction.Text = "";
        }
        /// <summary>
        /// Przycisk odopowiadający za usunięcie książki z bazy biblioteki
        /// po jej ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxId.Text);
            // Funkcja usuwająca książkę z bazy
            booksRepository.DeleteBook(bookId);

            // Odświeżenie tabel
            RefreshDataGridViewBooks();
            // Wyczyszczenie okien
            ClearTextBoxes();
        }
        /// <summary>
        /// Przycisk odpowiadający za zmianę wartości książki
        /// wymagane jest uzupełnienie jej wszystkich wartości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Pobranie odpowiednich wartości wpisanych przez użytkownika
            int bookId = int.Parse(textBoxId.Text);
            string personName = textBoxPersonName.Text;
            string title = textBoxTitle.Text;
            string genre = textBoxGenre.Text;
            string authorFirstName = textBoxAuthorFirstName.Text;
            string authorLastName = textBoxAuthorLastName.Text;
            string state = textBoxState.Text;
            string restriction = textBoxRestriction.Text;
            // Funkcja odpowiadająca za edytowanie książki
            booksRepository.EditBook(bookId, personName, title, genre, authorFirstName, authorLastName, state, restriction);

            // Odświeżenie tabel
            RefreshDataGridViewBooks();
            // Wyczyszczenie okien
            ClearTextBoxes();
        }
    }
}
