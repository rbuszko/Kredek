using Restauracja.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.ConcreteDecorator
{
    class MushroomsDecorator : PizzaDecorator
    {
        public MushroomsDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        /// <summary>
        /// Funkcja dodająca cenę grzybów do ceny pizzy
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.15;
        }

        /// <summary>
        /// Funkcja dodająca grzyby do listy składników
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return base.GetName() + " pieczarki";
        }
    }
}
