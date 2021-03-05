using Restauracja.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.ConcreteDecorator
{
    class TomatoSauceDecorator : PizzaDecorator
    {
        public TomatoSauceDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        /// <summary>
        /// Funkcja dodająca cenę sosu pomidorowego do bazowej ceny pizzy
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.40;
        }

        /// <summary>
        /// Funkcja dodająca składnik pizzy, do listy składników
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return base.GetName() + " sos pomidorowy";
        }
    }
}
