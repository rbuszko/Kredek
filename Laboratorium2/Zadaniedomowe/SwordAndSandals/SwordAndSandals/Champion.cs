using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class Champion:Creature, ISex
    {
        // Lista broni
        public List<Weapon> weapons = new List<Weapon>();

        // Lista zbroi
        public List<Armor> armors = new List<Armor>();

        // Obecnie noszona broń
        public Weapon currentWeapon = new Weapon("Miecz", 1, 1);

        // Obecnie noszona zbroja
        public Armor currentArmor = new Armor("Zbroja", 1, 1);

        /// <summary>
        /// Energia jaką posiada bohater
        /// </summary>
        int _energy;
        /// <summary>
        /// Punkty statusu bohatera, służą do zwiększenia atrybutów
        /// </summary>
        int _statusPoints;
        /// <summary>
        /// Dmg bohatera ze statusu
        /// </summary>
        int _baseDamage = 10;
        /// <summary>
        /// Obrona bohatera ze statusu
        /// </summary>
        int _baseDefence = 10;
        /// <summary>
        /// Doświadczenie potrzebne do następnego poziomu
        /// </summary>
        int _expToLvlUp = 10;
        /// <summary>
        /// Płeć
        /// </summary>
        bool _female = true;

        // Gettery i settery na atrybuty
        public int Energy { get { return _energy; } set { _energy = value; } }
        public int StatusPoints { get { return _statusPoints; } set { _statusPoints = value; } }
        public int BaseDamage { get { return _baseDamage; } set { _baseDamage = value; } }
        public int BaseDefence { get { return _baseDefence; } set { _baseDefence = value; } }
        public int ExpToLvlUp { get { return _expToLvlUp; } set { _expToLvlUp = value; } }
        public bool Female { get { return _female; } set { _female = value; } }

        /// <summary>
        /// Konstruktor bezparametryczny, inicjalizuje bohatera
        /// </summary>
        /// <param name="name"></param>
        public Champion()
        {
            Name = "xXKozakPLXx";
            Hp = 100;
            Energy = 100;
            Damage =  BaseDamage + currentWeapon.Damage;
            Defence = BaseDefence + currentArmor.Defence;
            Experience = 0;
            ExpToLvlUp = 100;
            Gold = 0;
            Lvl = 1;

            // Dodanie dwóch podstawowych broni
            weapons.Add(currentWeapon);
            armors.Add(currentArmor);           
        }
        /// <summary>
        /// Wbicie następnego poziomu
        /// </summary>
        public void LvlUp()
        {
            BaseDamage += 2;
            BaseDefence += 2;
            ExpToLvlUp = Lvl * 100;
            Experience = 0;
        }
        /// <summary>
        /// Zmienia płeć jakoś
        /// </summary>
        public void ChangeSex()
        {
            if (Female == true)
            {
                Name = "Sexi Buff";
                Female = false;
            }
            else if (Female == false)
            {
                Name = "xXKozakPLXx";
                Female = true;
            }
        }
    }
}
