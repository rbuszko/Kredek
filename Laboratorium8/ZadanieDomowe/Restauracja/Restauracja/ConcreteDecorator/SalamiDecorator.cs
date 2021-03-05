using Restauracja.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.ConcreteDecorator
{
    class SalamiDecorator : PizzaDecorator
    {
        public SalamiDecorator(Pizza pizza)
    : base(pizza)
        {
        }

        /// <summary>
        /// Funkcja dodająca cenę salami do ceny bazowej pizzy
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            return base.CalculateCost() + 4.15;
        }

        /// <summary>
        /// Funkcja dodająca salami do list składników pizzy
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return base.GetName() + " salami";
        }
    }
}
