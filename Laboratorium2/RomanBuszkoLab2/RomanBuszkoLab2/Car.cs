using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanBuszkoLab2
{
    class Car:Vehicle,IMilitary, IFlying
    {
        /// <summary>
        /// Kolor pojazdu
        /// </summary>
        public string color = "red";
        /// <summary>
        /// Rok wyprodukowania pojazdu
        /// </summary>
        public int year = 2020;
        /// <summary>
        /// Kolor tapicerki
        /// </summary>
        public string padding = "black";

        /// <summary>
        /// Właściwości - bieriera ochronna naszej klasy, przykład enkapsulacji
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Fuel { get { return fuel; } set { fuel = value; } }

        /// <summary>
        /// Konstruktor bezparametrowy
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="fuel"></param>
        public Car(string name, int speed, int fuel)
        {
            Name = name;
            Speed = speed;
            Fuel = fuel;
        }

        /// <summary>
        /// Funkcja przenosząca pojazd o konkretny dystans
        /// </summary>
        /// <param name="distance"></param>
        public void Fly(int distance)
        {
            fuel -= distance;
        }

        /// <summary>
        /// Funkcja malująca na kolor khaki tło ekranu
        /// </summary>
        /// <returns></returns>
        public Color PaintMilitary()
        {
            return System.Drawing.Color.DarkKhaki;
        }

        /// <summary>
        /// Funkcja malująca na kolor tło na kolor nieba
        /// </summary>
        /// <returns></returns>
        public Color PaintSky()
        {
            return System.Drawing.Color.SkyBlue;
        }

        /// <summary>
        /// Funkcja oddająca strzał
        /// </summary>
        /// <param name="power"></param>
        public void Shoot(int power)
        {
            fuel -= power;
        }
    }
}
