using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanBuszkoLab2
{
    abstract class Vehicle
    {
        /// <summary>
        /// Nazwa marki pojazdu
        /// </summary>
        public string name = "Audi";
        /// <summary>
        /// Prędkość maksymalna pojazdu
        /// </summary>
        public int speed = 230;
        /// <summary>
        /// Maksymalna pojemność baku
        /// </summary>
        public int fuel = 60;
        /// <summary>
        /// Różnica między obecnym i pełnym bakiem
        /// </summary>
        public int lostFuel = 0;

        /// <summary>
        /// Funkcja ruchu
        /// </summary>
        internal void Go()
        {
            speed++;
            fuel--;
            lostFuel++;
        }

        /// <summary>
        /// Funkcja napełnienia benzyny
        /// </summary>
        internal void FuelUp()
        {
            fuel += lostFuel;
            lostFuel = 0;
        }
    }
}
