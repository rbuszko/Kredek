using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class Enemy:Creature
    {
        // Stworzenie obiektu klasy random, do wprowadzenia
        // elementów losowych w grze
        Random usefulNumber = new Random();

        /// <summary>
        /// Konstruktor parametryczny 
        /// </summary>
        /// <param name="lvl"></param>
        public Enemy(int lvl)
        {
            Lvl = lvl;
            // W zależności od zmiennej ustawia konkretną nazwę potwora
            if (Lvl == 1)
            {
                Name = "Dziki pies";
            }
            else if (Lvl == 2)
            {
                Name = "Trujący pająk";
            }
            else if (Lvl == 3)
            {
                Name = "Czarny ork";
            }
        }
        // Konstruktor bezparametryczny
        public Enemy()
        {

        }

        /// <summary>
        /// Ustawia wartości statusu przeciwnika
        /// </summary>
        public void PickEnemy()
        {
            // Wprowadzają zmienność w sile przeciwnika
            int numberHp = usefulNumber.Next(50, 100);
            int numberDmg = usefulNumber.Next(1, 10);
            int numberDef = usefulNumber.Next(1, 10);

            Hp = numberHp * Lvl;
            Damage = numberDmg * Lvl;
            Defence = numberDef * Lvl;
            Experience = 10 * Lvl;
            Gold = 1 * Lvl;
        }
    }
}
