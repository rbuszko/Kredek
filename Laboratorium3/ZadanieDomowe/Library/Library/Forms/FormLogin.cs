using Library.Repositories;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// Okno do logowania
    /// </summary>
    public partial class FormLogin : Form
    {
        UsersRepository usersRepository = new UsersRepository();
        /// <summary>
        /// Konstruktor okna do ładowania
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();

            //Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do logowania
        /// Sprawdza czy login i hasło zostały poprawnie wpisane i
        /// czy zalogowano się jako pracownik, czy jako klient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoggin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            // Sprawdza login i hasło pracownika i klienta
            bool loggedWorker = usersRepository.LoginWorker(login, password);
            bool loggedClient = usersRepository.LoginClient(login, password);

            // Jeżeli konto pasuje do pracownika, otwiera konto pracownika
            if (loggedWorker)
            {
                Program.WorkerLogged = true;
                Close();
            }
            // Jeżeli konto pasuje do użytkownika, otwiera konto użytkownika
            if (loggedClient)
            {
                Program.ClientLogged = true;
                Close();
            }
            // W przypadku, gdy dane zostały błędnie uzupełnione
            MessageBox.Show("Niepoprawny login lub hasło!");
            textBoxPassword.Text = "";
            textBoxLogin.Text = "";
        }
    }
}
