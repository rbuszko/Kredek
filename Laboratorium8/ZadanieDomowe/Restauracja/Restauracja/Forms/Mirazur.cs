using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja
{
    public partial class Mirazur : Form
    {
        // Pierwszy kelner
        static Service waiter1 = Service.GetService();
        // Drugi kelner
        static Service waiter2 = Service.GetService();
        // Klient
        static Service client = Service.GetService();
        
        public Mirazur()
        {
            InitializeComponent();

            pictureBoxWaiter1.Parent = pictureBoxBackGround;
            pictureBoxWaiter2.Parent = pictureBoxBackGround;
        }

        private void Mirazur_Load(object sender, EventArgs e)
        {
            // Odświeżenie tabeli
            Refresh();
        }

        /// <summary>
        /// Funkcja służy do wyświetlenia bieżącej listy zamówień
        /// </summary>
        private void Refresh()
        {
            // Pobranie listy zamówień
            var orders = waiter1.GetOrders();
            // Wyczyszczenie poprzedniej tabeli
            listViewOrders.Items.Clear();

            // Dla wszystkich zamówień z listy zamówień
            foreach (var order in orders)
            {
                // Złożenie wiersza na podstawie zamówienia
                var row = new string[] { order.GetName(), order.CalculateCost().ToString() + " zł" };
                // Element listy
                var lvi = new ListViewItem(row);
                // Dodanie zamówienia do tabeli
                listViewOrders.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Przycisk służy do wywołania funkcji dodającej Margharitte do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMargherita_Click(object sender, EventArgs e)
        {
            // Dodajemy pizze
            client.AddPizza(1);
            // Odświeżamy tabele
            Refresh();
        }

        /// <summary>
        /// Przycisk służy do wywołania funkcji dodającej Funghi do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFunghi_Click(object sender, EventArgs e)
        {
            // Dodajemy pizze
            client.AddPizza(2);
            // Odświeżamy tabele
            Refresh();
        }

        /// <summary>
        /// Przycisk służy do wywołania funkcji dodającej Prosciutto do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProsciutto_Click(object sender, EventArgs e)
        {
            // Dodajemy pizze
            client.AddPizza(3);
            // Odświeżamy tabele
            Refresh();
        }

        /// <summary>
        /// Przycisk służy do wywołania funkcji dodającej Salame do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSalame_Click(object sender, EventArgs e)
        {
            // Dodajemy pizze
            client.AddPizza(4);
            // Odświeżamy tabele
            Refresh();
        }

        /// <summary>
        /// Przycisk odpowiadający za wywołanie funkcji odpowiadającej za przyjęcie zamówienia
        /// przez pierwszego kelnera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFirstWaiter_Click(object sender, EventArgs e)
        {
            // Usunięcie zamówienia
            waiter1.DeleteOrder();
            // Odświeżeni tabeli
            Refresh();
        }

        /// <summary>
        /// Przycisk odpowiadający za wywołanie funkcji odpowiadającej za przyjęcie zamówienia
        /// przez drugiego kelnera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSecondWaiter_Click(object sender, EventArgs e)
        {
            // Usunięcie zamówienia
            waiter2.DeleteOrder();
            // Odświeżenie tabeli
            Refresh();
        }
    }
}
