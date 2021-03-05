using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Tło etykiety przyjmuje kolor przeźroczysty
            labelLoading.Parent = pictureBoxOpening;
        }
        /// <summary>
        /// Funkcja timera odpowiadająca za początkową długość ładowania gry,
        /// po określonym czasie przenosi nas do nowego okna, w którym zaczynamy grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerŁadowanie_Tick(object sender, EventArgs e)
        {
            // Wyłączenie timera
            timerŁadowanie.Stop();
            // Schowanie okna ładowania
            Hide();
            // Inicjalizacja Okna gry
            OknoGry form = new OknoGry();
            // Otwiera Okno gry
            form.ShowDialog();
            // Zamyka okno ładowania
            Close();
        }
    }
}
