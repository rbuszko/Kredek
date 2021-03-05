using Restauracja.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.ConcreteDecorator
{
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza)
            : base(pizza)
        {

        }

        /// <summary>
        /// Funkcja dodająca cenę sera do ceny bazowej pizzy
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.15;
        }

        /// <summary>
        /// Funkcja dodająca ser do listy składników
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return base.GetName() + " ser";
        }
    }
}
