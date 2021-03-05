using LibraryV2.Repositories;
using System;
using System.Windows.Forms;

namespace LibraryV2.Forms
{
    public partial class FormKlient : Form
    {
        // Obiekt repozytorium użytkownika
        private BooksRepository booksRepository = new BooksRepository();

        public FormKlient()
        {
            InitializeComponent();
            // Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Funkcja służąca do odświeżenia dataGridViewBooksToLend
        /// </summary>
        private void RefreshDataGridViewBooksToLend()
        {
            dataGridViewBooksToLend.DataSource = booksRepository.GetBooksToRent();
        }
        /// <summary>
        /// Funkcja służąca do odświeżenia dataGridViewPersonBooks
        /// </summary>
        private void RefreshDataGridViewBooksPersonBooks()
        {
            dataGridViewPersonBooks.DataSource = booksRepository.GetUserBooks();
        }
        /// <summary>
        /// Funkcja służy do wyczyszczenia wszystkich TextBoxów
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
        }
        /// <summary>
        /// Metoda po wciśnięciu przycisku pozwala wypożyczyć książkę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLend_Click(object sender, EventArgs e)
        {
            // Przypisujemy odpowiednie wartości
            int bookId;
            try
            {
                bookId = int.Parse(textBoxId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Musisz podać jakieś Id!");
                return;
            }
            // Wypożyczamy książkę
            bool isLended = booksRepository.LendBook(bookId);
            if (isLended)
            {
                // Odświeżamy tabelę
                RefreshDataGridViewBooksToLend();
                RefreshDataGridViewBooksPersonBooks();
                // Czyścimy okienka
                ClearTextBoxes();
            }
            // Jeżeli nie, to wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Książka nie jest dla Ciebie dostępna, bądź jesteś za młody!");
            }
        }
        /// <summary>
        /// Metoda po wciśnięciu przycisku pozwala zwrócić książkę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            // Przypisujemy odpowiednie wartości
            int bookId;
            try
            {
                bookId = int.Parse(textBoxId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Musisz podać jakieś Id!");
                return;
            }
            // Wypożyczamy książkę
            bool isReturned = booksRepository.ReturnBook(bookId);
            if (isReturned)
            {
                // Odświeżamy tabelę
                RefreshDataGridViewBooksToLend();
                RefreshDataGridViewBooksPersonBooks();
                // Czyścimy okienka
                ClearTextBoxes();
            }
            // Jeżeli nie, to wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Książka nie może zostać zwrócona, sprawdź poprawność id!");
            }
        }

        private void FormKlient_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewBooksToLend();
            RefreshDataGridViewBooksPersonBooks();
        }
    }
}
