using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public abstract class Item
    {
        // Nazwa przedmiotu
        string _name = "";
        // Cena przedmiotu
        int _price = 0;
        // Poziom przedmiotu
        int _level = 0;
        
        // Gettery i settery na parametry
        public string Name { get { return _name;} set { _name = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public int Level { get { return _level; } set { _level = value; } }

    }
}
