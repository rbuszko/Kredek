using Restauracja.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja
{
    class Service
    {
        // Tworzymy wspólną instancje klasy service
        private static readonly Service _instance = new Service();
        // Lista zamówień do wykonania
        private List<Pizza> orders = new List<Pizza>();

        /// <summary>
        /// Konstruktor bezparametryczny
        /// </summary>
        private Service()
        {

        }

        /// <summary>
        /// Zwrócenie stworzonej instancji klasy service
        /// </summary>
        /// <returns></returns>
        public static Service GetService()
        {
            return _instance;
        }

        /// <summary>
        /// Funkcja służąca do pobrania listy zamówień
        /// </summary>
        /// <returns></returns>
        public List<Pizza> GetOrders()
        {
            return orders;
        }

        /// <summary>
        /// Funkcja służy do dodania pizzy do listy zamówień
        /// </summary>
        public void AddPizza(int number)
        {
            // Tworzymy obiekt pizzy
            Pizza pizza = new Pizza();
            // Dodajemy składniki znajdujące się w każdej pizzy
            pizza = new TomatoSauceDecorator(pizza);
            pizza = new CheeseDecorator(pizza);
            // Składniki specjalne pizz
            switch (number)
            {
                case 1:
                    orders.Add(pizza);
                    break;
                case 2:
                    pizza = new MushroomsDecorator(pizza);
                    orders.Add(pizza);
                    break;
                case 3:
                    pizza = new HamDecorator(pizza);
                    orders.Add(pizza);
                    break;
                case 4:
                    pizza = new SalamiDecorator(pizza);
                    orders.Add(pizza);
                    break;
            }
        }

        /// <summary>
        /// Funkcja ostatnie złożone zamówienie
        /// </summary>
        public void DeleteOrder()
        {
            // Jeżeli istnieje jakieś zamówienie
            if (orders.Count > 0)
            {
                orders.RemoveAt(0);
            }
            // W przeciwnym przypadku
            else MessageBox.Show("Nie ma zamówienia, które mógłbyś przyjąć!", "Błąd", MessageBoxButtons.OK);
        }
    }
}
