using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanBuszkoLab2
{
    interface IFlying
    {
        /// <summary>
        /// Funkcja odpowiadająca za przelecenie odległości 
        /// </summary>
        /// <param name="distance"></param>
        void Fly(int distance);

        /// <summary>
        /// Funkcja malująca otoczenie na kolor nieba
        /// </summary>
        /// <returns></returns>
        System.Drawing.Color PaintSky();
    }
}
