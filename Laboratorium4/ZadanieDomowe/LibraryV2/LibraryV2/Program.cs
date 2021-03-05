using LibraryV2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryV2
{
    static class Program
    {
        // Zmienna statyczna przeprowadzająca przez proces logowania
        public static string Logged;
        // Zmienna stanu do określenia użytkownika
        public static string user;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            // Jeśli udało się zalogować jako konkretny użytkownik
            if (Logged == "Admin") Application.Run(new FormAdmin());
            else if (Logged == "Pracownik") Application.Run(new FormWorker());
            else if (Logged == "Klient") Application.Run(new FormKlient());
        }
    }
}
