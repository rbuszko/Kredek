using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwordAndSandals
{
    public partial class Arena : Form
    {
        /// <summary>
        /// Instancja miasta w celu uzyskania dostępu do
        /// naszego bohatera
        /// </summary>
        private City city;

        /// <summary>
        /// Przeciwnik, z którym będziemy walczyć
        /// </summary>
        Enemy enemyFound;

        /// <summary>
        /// True - tura gracza, false - tura przeciwnika
        /// </summary>
        bool turn = true;

        /// <summary>
        /// Konstruktor Areny z dostępem do miasta
        /// </summary>
        /// <param name="city"></param>
        public Arena(City city)
        {
            this.city = city;
            InitializeComponent();
            // Jeżeli kobieta, to zmieniamy zdjęcie i nick
            if (city.champion.Female == false)
            {
                pictureBoxChampion.Image = SwordAndSandals.Properties.Resources.mmm;
            }
            else pictureBoxChampion.Image = SwordAndSandals.Properties.Resources.champion;
            // Przeźroczyste tło potwora
            pictureBoxEnemy.Parent = pictureBoxArenaBackground;
            pictureBoxChampion.Parent = pictureBoxArenaBackground;
        }

        /// <summary>
        /// Przydziela nam przeciwnika 1 poziomowego, ustawiamy odpowiednią grafikę
        /// włączamy timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnemyLvl1_Click(object sender, EventArgs e)
        {
            enemyFound = city.enemys.Where(x => x.Lvl == 1).FirstOrDefault();
            pictureBoxEnemy.Image = SwordAndSandals.Properties.Resources.dog;
            timerFightTime.Start();
        }
        /// <summary>
        /// Przydziela nam przeciwnika 2 poziomowego, ustawiamy odpowiednią grafikę
        /// włączamy timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnemyLvl2_Click(object sender, EventArgs e)
        {
            enemyFound = city.enemys.Where(x => x.Lvl == 2).FirstOrDefault();
            pictureBoxEnemy.Image = SwordAndSandals.Properties.Resources.pajak;
            timerFightTime.Start();
        }
        /// <summary>
        /// Przydziela nam przeciwnika 3 poziomowego, ustawia odpowiednią grafikę
        /// włączamy timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnemyLvl3_Click(object sender, EventArgs e)
        {
            enemyFound = city.enemys.Where(x => x.Lvl == 3).FirstOrDefault();
            pictureBoxEnemy.Image = SwordAndSandals.Properties.Resources.ork;
            timerFightTime.Start();
        }
        /// <summary>
        /// Zakończenie pojedynku, true wygrana, false przegrana
        /// </summary>
        void Result()
        {
            // Gracz wygrał
            if (enemyFound.Hp <= 0)
            {
                // Zatrzymujemy stoper
                timerFightTime.Stop();
                // Gracz dostaje złoto
                city.champion.Gold += enemyFound.Gold;
                // Gracz dostaje expa
                city.champion.Experience += enemyFound.Experience;
                // Wyświetlamy przycisk zakończ
                buttonEnd.Visible = true;
                // Chowamy przyciski
                buttonLightHit.Hide();
                buttonMediumHit.Hide();
                buttonStrongHit.Hide();
            }
            // Przeciwnik wygrał
            else if (city.champion.Hp <= 0)
            {
                // Zatrzymujemy stoper
                timerFightTime.Stop();
                // Gracz ma 1 życia po przegranej
                city.champion.Hp = 1;
                // Gracz traci złoto
                if (city.champion.Gold < 2) city.champion.Gold = 0;
                else city.champion.Gold -= 2;
                // Wyświetlamy przycisk zakończ
                buttonEnd.Visible = true;
                // Chowamy przyciski
                buttonLightHit.Hide();
                buttonMediumHit.Hide();
                buttonStrongHit.Hide();
            }
        }
        /// <summary>
        /// Czas walki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFightTime_Tick(object sender, EventArgs e)
        {
            // Sprawdzenie wyniku
            Result();

            // Atak przeciwnika
            if (turn == false)
            {
                if (enemyFound.Damage >= city.champion.Defence)
                    city.champion.Hp -= 10;
                else city.champion.Hp -= 2;
                turn = true;
            }

            // Odwieżenie kontrolek
            textBoxChampionName.Text = city.champion.Name;
            textBoxMonsterName.Text = enemyFound.Name;
            textBoxEnemyLife.Text = enemyFound.Hp.ToString();
            textBoxYourLife.Text = city.champion.Hp.ToString();
        }

        /// <summary>
        /// Przycisk rozpoczęcia walki, blokuje przyciski wyboru przeciwnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Warunkiem rozpoczęcia jest wybranie przeciwnika
            if (textBoxMonsterName.Text != "Życie przeciwnika")
            {
                // Blokowanie przycisku wyboru przeciwnika
                buttonEnemyLvl1.Enabled = false;
                buttonEnemyLvl2.Enabled = false;
                buttonEnemyLvl3.Enabled = false;
                
                // Schowanie przycisku startu
                buttonStart.Hide();

                // Uwidocznienie przycisków ataku
                buttonLightHit.Visible = true;
                buttonMediumHit.Visible = true;
                buttonStrongHit.Visible = true;
            }
        }
        /// <summary>
        /// Funkcja służąca do zadawania obrażeń
        /// </summary>
        int DealDmg()
        {
            // Obrażenia
            int damage = 10;
            // Obrażenia jeżeli mamy większy atak niż przeciwnik obronę
            if (city.champion.Damage >= enemyFound.Defence)
                damage = 10 + (city.champion.Damage - enemyFound.Defence);
            // Obrażenia jeżeli mamy mniejszy atak niż przeciwnik obronę
            if (city.champion.Damage < enemyFound.Defence)
                damage = 10;
            
            return damage;
        }
        /// <summary>
        /// Funckaj, która określa naszą szansę trafienia przeciwnika
        /// </summary>
        /// <returns></returns>
        int AttackChance()
        {
            // Stworzenie obiektu klasy random, do wprowadzenia
            // elementów losowych w grze
            Random usefulNumber = new Random();
            // Zwraca wartość od 25 do 33 
            return usefulNumber.Next(25, 33);
        }
        /// <summary>
        /// Funkcja do sprawdzenia czy nasz atak trafił przeciwnika
        /// </summary>
        /// <param name="attackChance"></param>
        /// <returns></returns>
        bool AttackResult(int attackChance)
        {
            Result();
            // Stworzenie obiektu klasy random, do wprowadzenia
            // elementów losowych w grze
            Random usefulNumber = new Random();
            // Losujemy numer z póli
            int chance = usefulNumber.Next(1, 100);
            // Sprawdzamy czy trafiliśmy
            if (chance <= attackChance) return true;
            else return false;
        }
        /// <summary>
        /// Mocny atak, mała szansa uderzenia podwójne obrażenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrongHit_Click(object sender, EventArgs e)
        {
            // Jeżeli nasza tura
            if (turn == true)
            {
                // Sprawdź rezultat
                Result();
                // Jeżeli trafiliśmy to zmniejszmay atak
                if (AttackResult(AttackChance()) == true) enemyFound.Hp -= DealDmg() * 3;
                // Tura przeciwnika
                turn = false;
            }
        }
        /// <summary>
        /// Średni atak, średnia szansa uderzenia, obrażneia x 1.5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMediumHit_Click(object sender, EventArgs e)
        {
            // Jeżeli nasza tura
            if (turn == true)
            {
                // Sprawdź rezultat
                Result();
                // Jeżeli trafiliśmy to zmniejszmay atak
                if (AttackResult(AttackChance() * 2) == true) enemyFound.Hp -= DealDmg() * 2;
                // Tura przeciwnika
                turn = false;
            }
        }
        /// <summary>
        /// Słaby atak, duża szansa trafienia, obrażenia x 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLightHit_Click(object sender, EventArgs e)
        {
            // Jeżeli nasza tura
            if (turn == true)
            {
                // Sprawdź rezultat
                Result();
                // Jeżeli trafiliśmy to zmniejszmay atak
                if (AttackResult(AttackChance() * 3) == true) enemyFound.Hp -= DealDmg();
                // Tura przeciwnika
                turn = false;
            }
        }
        /// <summary>
        /// Wyjście z pojedynku, zamknięcie okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
