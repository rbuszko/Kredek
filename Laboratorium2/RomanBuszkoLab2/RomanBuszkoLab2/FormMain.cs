using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanBuszkoLab2
{
    public partial class FormMain : Form
    {
        // Pojazd testowy
        Car car;

        // Tworzę listę obiektów typu car
        List<Car> cars = new List<Car>();

        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk odpowiadający za tworzenie nowego obietku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Tworzenie nowego obietku
            car = new Car();
            RefreshTextBoxes();
        }

        /// <summary>
        /// Funkcja odświeżająca kontrolki
        /// </summary>
        private void RefreshTextBoxes()
        {
            // Wypełnianie kontrolek danymi obietku
            textBoxName.Text = car.name;
            textBoxSpeed.Text = car.speed.ToString();
            textBoxFuel.Text = car.fuel.ToString();
            textBoxColor.Text = car.color;
            textBoxYear.Text = car.year.ToString();
            textBoxPadding.Text = car.padding;
        }

        /// <summary>
        /// Przycisk odpowiedzialny za uruchomienie ruchu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrive_Click(object sender, EventArgs e)
        {
            try
            {
                // Funkcja poruszania się pojazdu
                car.Go();
                RefreshTextBoxes();
            }
            catch (Exception)
            {
                //reakcja
            }
        }

        /// <summary>
        /// Przycisk ładujący benzynę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFuelUp_Click(object sender, EventArgs e)
        {
            // Funkcja zatankowania pojazdu
            car.FuelUp();
            RefreshTextBoxes();
        }

        /// <summary>
        /// Przycisk wywołujący funkcje militarne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMilitary_Click(object sender, EventArgs e)
        {
            // Przypisanie koloru wojskowego
            BackColor = car.PaintMilitary();
            // Strzał o wybranej mocy
            car.Shoot(10);

            RefreshTextBoxes();
        }

        /// <summary>
        /// Przycisk wywołujący funkcje latania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Przypisanie koloru nieba
            BackColor = car.PaintSky();
            // Przebycie dystansu o konkretnej wartości
            car.Fly(27);

            RefreshTextBoxes();
        }
        /// <summary>
        /// Przycisk tworzący listę obiektów typu car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonList_Click(object sender, EventArgs e)
        {
            cars.Add(new Car("Ferrari", 300, 40));
            cars.Add(new Car("Bentley", 300, 40));
            cars.Add(new Car("Audi", 300, 40));
            cars.Add(new Car("Żuk", 300, 40));
            cars.Add(new Car("Yaris", 300, 40));

            dataGridViewVehicles.DataSource = cars;
        }

        /// <summary>
        /// Przycisk wyszukujący pojazdu na liście
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie samochodu po nazwie zdefiniowanej w TeXtBox
            Car carFound = cars.Where(x => x.Name == textBoxName.Text).FirstOrDefault();

            // Przypisanie danych dla odnalezionego samochodu
            textBoxSpeed.Text = carFound.Speed.ToString();
            textBoxFuel.Text = carFound.Fuel.ToString();
        }
    }
}
