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
    /// <summary>
    /// Klasa okna klienta
    /// </summary>
    public partial class FormClient : Form
    {
        // Zmienne identyfikujące zalogowanego użytkownika
        string firstName;
        string lastName;
        int age;
        // Obiekt repozytorium użytkownika
        UsersRepository usersRepository = new UsersRepository();
        // Obiekt repozytorium książek
        BooksRepository booksRepository = new BooksRepository();
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // Przypisuje wartości, żeby znać dane użytkownika
            usersRepository.AssignIdentity(ref firstName, ref lastName, ref age);
            // Wyświetlanie przypisanych danych
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
            textBoxAge.Text = age.ToString();
            textBoxRole.Text = Program.Role;

            //Aktualizacja danych w DataGridViewBooks przy ładowaniu okna
            RefreshDataGridViewBooks();
        }

        /// <summary>
        /// Metoda odświeżająca dane w DataGridViewBooks
        /// </summary>
        private void RefreshDataGridViewBooks()
        {
            DataTable booksToLend;
            // pobierz wszystkie dostępne dla Ciebie książki z bazy danych
            if (age <= 18) booksToLend = booksRepository.GetBooks(1, firstName);
            else booksToLend = booksRepository.GetBooks(3, firstName);

            // pobierz wszystkie Twoje książki
            DataTable booksPerson = booksRepository.GetBooks(4, firstName);

            // przypisz przypisz książki do wypożyczenia do DataGridView
            dataGridViewBooksToLend.DataSource = booksToLend;
            // przypisz książki, które posiadasz do DataGridView 
            dataGridViewPersonBooks.DataSource = booksPerson;
        }
        /// <summary>
        /// Przycisk odpowiadający za wypożyczenie książki po jej ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLend_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            booksRepository.LendBook(firstName, id);

            //Aktualizacja danych w DataGridViewBooks przy ładowaniu okna
            RefreshDataGridViewBooks();
        }
        /// <summary>
        /// Przycisk odpowiadający za zwrócenie książki po jej ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            booksRepository.ReturnBook(id);
            //Aktualizacja danych w DataGridViewBooks przy ładowaniu okna
            RefreshDataGridViewBooks();
        }
    }
}
