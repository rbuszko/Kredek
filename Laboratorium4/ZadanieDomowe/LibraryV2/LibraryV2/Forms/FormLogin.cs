using LibraryV2.Forms;
using LibraryV2.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryV2
{
    public partial class FormLogin : Form
    {
        // Zmienna odpowiadająca za rodzaj użytkownika
        string who = "";
        // Obiekt repozytorium użytkownika
        private UsersRepository usersRepository = new UsersRepository();

        public FormLogin()
        {
            InitializeComponent();
            // Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Przycisk wyboru, przypisuje kryterium wyszukiwania umożliwiające zalogowanie się
        /// jako Admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            who = "Admin";
        }
        /// <summary>
        /// Przycisk wyboru, przypisuje kryterium wyszukiwania umożliwiające zalogowanie się
        /// jako Pracownik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWorker_Click(object sender, EventArgs e)
        {
            who = "Pracownik";
        }
        /// <summary>
        /// Przycisk wyboru, przypisuje kryterium wyszukiwania umożliwiające zalogowanie się
        /// jako Klient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClient_Click(object sender, EventArgs e)
        {
            who = "Klient";
        }
        /// <summary>
        /// Przycisk odpowiadający za otworzenie nowego okna w zależności od
        /// rodzaju użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy wybraliśmy rodzaj użytkownika
            if (who == "")
            {
                // Wyświetlenie komunikatu o niewybranym 
                MessageBox.Show("Nie wybrano rodzaju użytkownika!");
                // Wyczyszczenie okienek
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                return;
            }
            // Sprawdzenie czy podane konto istnieje
            if (usersRepository.CheckUser(textBoxLogin.Text, textBoxPassword.Text, who))
            {
                // Przypisanie odpowiedniej zmiennej 
                Program.Logged = who;
                // Zamknięcie okna
                Close();
            }
            else
            {
                // Wyświetlenie komunikatu o nieprawidłowym logowaniu
                MessageBox.Show("Nieprawidłowe dane logowania");
                // Wyczyszczenie okienek
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
