using Restauracja.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.ConcreteDecorator
{
    class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza)
            : base(pizza)
        {

        }

        /// <summary>
        /// Funkcja dodająca cenę szynki do bazowej ceny pizzy
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            return base.CalculateCost() + 3.15;
        }

        /// <summary>
        /// Funkcja dodająca szynkę do listy składników pizzy
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return base.GetName() + " szynka";
        }
    }
}
