using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanBuszkoLab2
{
    interface IMilitary
    {
        /// <summary>
        /// Funkcja odpowiadająca za strzał
        /// </summary>
        /// <param name="power"></param>
        void Shoot(int power);
        
        /// <summary>
        /// Funkcja malująca pojazd na kolor wojskowy
        /// </summary>
        /// <returns></returns>
        System.Drawing.Color PaintMilitary();
    }
}
