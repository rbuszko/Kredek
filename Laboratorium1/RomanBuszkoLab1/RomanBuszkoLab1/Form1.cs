using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanBuszkoLab1
{
    public partial class Form1 : Form
    {
        // Zmienna licznika
        int counter = 0;

        // Zmienan 2 licznika
        int counter2 = 0;

        // Zmienna nowego okna
        FormAbout formAbout;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk zmieniajacy kolor 2 przycisku oraz kolor tła.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            buttonColor2.BackColor = Color.Red;
        }
        /// <summary>
        ///  Przycisk zmieniający kolor 1 przycisku oraz tekst pierwszego przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor2_Click(object sender, EventArgs e)
        {
            buttonColor1.BackColor = Color.BlueViolet;
            buttonColor1.Text = "Kolor zmieniony";
        }
        /// <summary>
        /// Dodanie wartości do zmiennej z TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            // Zamiana typu String na Int
            counter = counter + Int32.Parse(textBoxCount.Text);

            // Zależność warunkowa
            if (counter > 100) counter = 0;

            if (counter % 2 == 0) IntColor.BackColor = Color.Yellow;
            else IntColor.BackColor = Color.Brown;

            // Zamiana typu liczbowego na tekstowy
            textBoxCount.Text = counter.ToString();
        }
        /// <summary>
        /// Mnoży wartości textboxow przez siebie i pokazuje wartość w drugim TextBoxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            counter2 = counter * counter2;
            textBoxCount2.Text = counter2.ToString();
        }
        /// <summary>
        /// Oddaje wartość pomnożenia 2 textboxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCount2_TextChanged(object sender, EventArgs e)
        {
            counter2 = Int32.Parse(textBoxCount2.Text);
        }
        /// <summary>
        /// Przycisk uruchamiający licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            timerCounter.Start();
        }
        /// <summary>
        /// Funkcja obsługująca wywołanie zegarowe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick_1(object sender, EventArgs e)
        {
            //Inkrementacja zmiennej licznik
            counter++;
            //przypisanie wartości licznika do pola tekstowego
            textBoxCount.Text = counter.ToString();

            // Zgodnie z zegarem zmienia położenie przycisku pomnóż
            if (counter % 2 == 0) buttonMultiply.Location = new Point(100, 200);
            else buttonMultiply.Location = new Point(100, 300);
        }
        /// <summary>
        /// Przycisk tworzący nowe okno, inicjalizujący nową stronę, ustawia nazwę label na Romek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Click(object sender, EventArgs e)
        {
            formAbout = new FormAbout();
            formAbout.myName = "Romek";
            formAbout.Show();
        }
    }
}
