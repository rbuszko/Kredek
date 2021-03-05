using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RomanBuszkoLab2
{
    class Bus:Vehicle
    {
        /// <summary>
        /// Ilość pasażerów
        /// </summary>
        public int passengerAmount = 20;

        internal void WaitForPassaners()
        {
            Thread.Sleep(2000);
        }
    }
}
