using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public abstract class Creature
    {
        /// <summary>
        /// Nazwa stworzenia
        /// </summary>
        string _name;
        /// <summary>
        /// Ilość życia stworzenia
        /// </summary>
        int _hp;
        /// <summary>
        /// Ilość obrażeń jaką zadaje stworzenie
        /// </summary>
        int _damage;
        /// <summary>
        /// Obrona jaką posiada stworzenie
        /// </summary>
        int _defence;
        /// <summary>
        /// Ilość doświadczenia
        /// </summary>
        int _experience;
        /// <summary>
        /// Złoto
        /// </summary>
        int _gold;
        /// <summary>
        /// Poziom stworzenia
        /// </summary>
        int _lvl;

        // Gettery i settery na atrybuty
        public string Name { get { return _name; } set { _name = value; } }
        public int Hp { get { return _hp; } set { _hp = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public int Defence { get { return _defence; } set { _defence = value; } }
        public int Experience { get { return _experience; } set { _experience = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int Lvl { get { return _lvl; } set { _lvl = value; } }
    }
}
