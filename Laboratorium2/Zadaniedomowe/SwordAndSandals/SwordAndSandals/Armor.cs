using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class Armor:Item
    {
        // Obrona przedmiotu
        int _defence = 1;

        // Bazowa obrona przedmiotu
        int _baseDefence = 1;

        // Gettery i settery dla atrybutów
        public int Defence { get { return _defence; } set { _defence = value; } }
        public int BaseDefence { get { return _baseDefence; } set { _baseDefence = value; } }
        /// <summary>
        /// Konstruktor parametryczny pancerza, uzupełnia atrybuty
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Armor(string name, int price, int baseDefence)
        {
            BaseDefence = baseDefence;
            _defence = baseDefence;
            Name = name;
            Price = price;
            Level = 1;
        }
    }
}
