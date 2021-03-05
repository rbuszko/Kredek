using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Decorator
{
    class PizzaDecorator : Pizza
    {
        // Obiekt, który będzie dekorowany
        protected Pizza _pizza;

        /// <summary>
        /// Konstruktor parametryczny przypisujący pizzę
        /// </summary>
        /// <param name="pizza"></param>
        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        /// <summary>
        /// Funkcja zwracająca całkowity koszt pizzy
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        /// <summary>
        /// Pizza zwracająca wszystkie składniki pizzy
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return _pizza.GetName();

        }
    }
}
