using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class LastBoss : Enemy
    {
        // Regeneracja życia na sekunde
        int _regeneration = 10;

        // Ustawienie setterów i getterów
        public int Regeneration { get { return _regeneration; } set { _regeneration = value; } }
        
        /// <summary>
        /// Konstruktor bezparametryczny bossa, ustawienie statystyk
        /// </summary>
        public LastBoss()
        {
            Name = "Ripper";
            Hp = 500;
            Damage = 60;
            Defence = 60;
            Experience = 60;
            Lvl = 6;
            Gold = 1 * Lvl;
        }
    }
}
