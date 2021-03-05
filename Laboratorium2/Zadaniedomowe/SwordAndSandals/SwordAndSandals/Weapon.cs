using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class Weapon:Item
    {
        // Atak przedmiotu
        int _damage = 1;
        // Bazowy atak przedmiotu
        int _baseDamage = 1;

        // Gettery i settery dla atrybutów
        public int Damage { get { return _damage; } set { _damage = value; } }

        public int BaseDamage { get { return _baseDamage; } set { _baseDamage = value; } }
        /// <summary>
        /// Konstruktor parametryczny broni
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="damage"></param>
        public Weapon(string name, int price, int baseDamage)
        {
            BaseDamage = baseDamage;
            Damage = baseDamage;
            Name = name;
            Price = price;
            Level = 1;
        }
    }
}
