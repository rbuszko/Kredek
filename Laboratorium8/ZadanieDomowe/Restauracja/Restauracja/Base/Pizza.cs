using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja
{
    public class Pizza
    {
        /// <summary>
        /// Funkcja zwracająca podstawowy koszt pizzy
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateCost()
        {
            return 10.00;
        }
        /// <summary>
        /// Funkcja zwracająca nazwę "Pizza"
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return "Pizza:";
        }
    }
}
