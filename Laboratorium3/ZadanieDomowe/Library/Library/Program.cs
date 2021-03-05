using Library.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        // Zmienne statyczne przeprowadzające przez proces logowania
        // Pracownika i Klienta
        public static bool WorkerLogged;
        public static bool ClientLogged;

        // Zmienna statyczna do otrzymania loginu, hasła i zawodu użytkownika
        public static string Login;
        public static string Password;
        public static string Role;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            // Jeśli udało się zalogować jako klient
            if (ClientLogged)
                Application.Run(new FormClient());
            // Jeśli udało się zalogować jako pracownik
            else if (WorkerLogged)
                Application.Run(new FormWorker());
        }
    }
}
