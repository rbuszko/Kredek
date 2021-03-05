using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe
{
    public partial class OknoGry : Form
    {
        // Zmienna odpowiadająca za licznik służy do
        // zmiany atrybutów pokemona
        int counter = 0;
        // Zmienna odpowiadająca za życie
        int life = 100;
        // Zmienna odpowiadająca za energię
        int energy = 100;
        // Zmienna odpowiadająca za atak
        int attack = 0;
        // Zmienna odpowiadająca za obronę
        int defence = 0;
        // Zmienna odpowiadająca za głód
        int hunger = 100;
        // Zmienna ataku potwora
        int monsterAttack;
        // Zmienna obrony potwora
        int monsterDefence;
        // Zmienna doświadczenia pokemona
        int experience = 0;
        // Zmienna ewolucji
        bool evolution = false;

        // Skala siły potworów
        int monsterScale = 1;
        // Skala uszkodzeń po zjedzeniu nieświeżego jedzenia
        int disaster;

        // Momentyów
        int firstEvent;
        int secondEvent;

        // Zmienna nowego okna
        Walka fightWindow;

        public OknoGry()
        {
            InitializeComponent();

            // Tło pokemona przed ewolucją przyjmuje kolor przeźroczysty
            pictureBoxPokemonBeforeEvolution.Parent = pictureBoxBackGround;
            // Tło pokemona po ewolucji przyjmuje kolor przeźroczysty
            pictureBoxPokemonAfterEvolution.Parent = pictureBoxBackGround;

            // Schowanie pokemona po ewolucji do czasu ewolucji
            pictureBoxPokemonAfterEvolution.Hide();

            // Stworzenie obiektu klasy random, do wprowadzenia
            // elementów losowych w grze
            Random usefulNumber = new Random();

            // Tworzenie randomowych początkowych atrybutów, momentów zdarzeń
            // i poziomu zdarzeń
            for (int i = 0; i < 2; i++)
            {
                // Zakres losowości
                int attrubutnumber = usefulNumber.Next(0, 30);
                int eventNumber = usefulNumber.Next(0, 30);
                int eventScale = usefulNumber.Next(2, 3);

                // Momenty, w których eventy mają miejsce i przyporządkowanie atrybutów
                // i skala eventu
                if (i == 0)
                {
                    attack = attrubutnumber;
                    firstEvent = eventNumber;
                    monsterScale = eventScale;
                }
                if (i == 1)
                {
                    defence = attrubutnumber;
                    secondEvent = eventNumber;
                    disaster = eventScale;
                }

            }

            // Przypisanie wartości do etykiety atrybutów
            textBoxLife.Text = life.ToString();
            textBoxEnergy.Text = energy.ToString();
            textBoxAttack.Text = attack.ToString();
            textBoxDefence.Text = defence.ToString();
            textBoxHunger.Text = hunger.ToString();
            textBoxExperience.Text = experience.ToString();
        }
        /// <summary>
        /// Funkcja obsługująca wywołania zegarowe, odpowiada
        /// za wykonanie konktretnych zdarzeń w zależności od
        /// czasu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            // Inkrementacja zmiennej licznika
            counter++;

            // Dekrementacja zmiennej hunger
            if (hunger > 0) hunger--;

            // Funkcja warunkowa uzupełniania energii
            if (energy < 100) energy++;

            // Funkcja wzrostu życia
            if (hunger > 50 && life < 100) life++;

            // Funkcja spadku życia
            if (hunger == 0) life--;

            // Funkcja służy do zmiany kolor przycisków
            // w przypadku gdy nie można ich użyć
            if (hunger > 0)
            {
                buttonAttack.BackColor = Color.Gainsboro;
                buttonDefence.BackColor = Color.Gainsboro;
            }

            // Funkcja ewolucji, zdarzenie, chowa pictureBoxa pokemona przed ewolucją
            // Zwiększa statystyki
            if (experience >= 30 && evolution == false)
            {
                evolution = true;
                pictureBoxPokemonBeforeEvolution.Hide();
                pictureBoxPokemonAfterEvolution.Show();
                MessageBox.Show("Po Twojej ostateniej walce, Twój pokemon zaczął się jakoś dziwnie zachowywać. Zmienia się."+
                    "Przed Tobą pojawił się smukły pokemon z czarnym ciałem, szkarłatnymi oczami i żółtymi pierścieniami." +
                    "Twój pokemon zwiększa swoje statystyki dwukrotnie.", "Piękny pokemon!", MessageBoxButtons.OK);
                attack *= 2;
                defence *= 2;
            }
              
            // Wyświetlenie pierwszego eventu
            if(counter == firstEvent)
            {
                MessageBox.Show("Nagle przed Tobą pojawiła się dziwna czarna dziura, wszedłeś do środka. " +
                "Przeniosłeś się 3 lata w czasie wszystkie potwory są " +
                 monsterScale +" razy silniejsze", "Co to za dziura?", MessageBoxButtons.OK);
                monsterScale = 2;
            }

            // Wyświetlenie drugiego eventu
            if (counter == secondEvent)
            {
                MessageBox.Show("Twój pokemon zjadł coś nieświeżego, wszystkie Twoje statystki" +
                    " zmalały "+ disaster + "-krotnie", "Dziwny owoc.", MessageBoxButtons.OK);
                attack = attack / 2;
                defence = defence / 2;
            }

            // Stworzenie obiektu klasy random, do generowania
            // siły i obrony potwora
            Random monsterNumber = new Random();
            // Funkcja służy do obliczenia siły i obrony potwora
            for (int i = 0; i < 2; i++)
            {
                int number = monsterNumber.Next(0, counter);
   
                if (i == 0) monsterAttack = number * monsterScale;
                if (i == 1) monsterDefence = number * monsterScale;
            }

            // Wyświetlanie bieżących atrybutów pokemona
            textBoxHunger.Text = hunger.ToString();
            textBoxEnergy.Text = energy.ToString();
            textBoxLife.Text = life.ToString();
            textBoxAttack.Text = attack.ToString();
            textBoxDefence.Text = defence.ToString();
            textBoxExperience.Text = experience.ToString();
        }
        /// <summary>
        /// Funkcja służy do zwiększenia ataku pokemona
        /// W przypadku, w którym nie mamy wystarczającej ilości energii
        /// przycisk zmienia kolor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (energy > 0)
            {
                attack++;
                energy--;
                textBoxAttack.Text = attack.ToString();
            }
            else buttonAttack.BackColor = Color.DarkRed;
        }
        /// <summary>
        /// Funkcja służy do zwiększenia obrony pokemona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDefence_Click(object sender, EventArgs e)
        {
            if (energy > 0)
            {
                defence++;
                energy--;
                textBoxDefence.Text = defence.ToString();
            }
            else buttonDefence.BackColor = Color.DarkRed;
        }
        /// <summary>
        /// Funkcja służy do nakarmienia pokemona
        /// Odnawia życie i głodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeed_Click(object sender, EventArgs e)
        {
            if (life < 100) life++;
            if (hunger >= 96) hunger = 101;
            if (hunger < 96) hunger = hunger + 4;
        }
        /// <summary>
        /// Funkcja służy do przejścia do okna walki, walka
        /// odbywa się w oknie, przekazuje potrzebne dane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWalcz_Click(object sender, EventArgs e)
        {
            using (fightWindow = new Walka())
            {   
                // Przekazuje na arenę potrzebne wartości
                fightWindow.monsterAttack = monsterAttack;
                fightWindow.monsterDefence = monsterDefence;
                fightWindow.pokemonAttack = attack;
                fightWindow.pokemonDefence = defence;
                fightWindow.pokemonLife = life;

                // Pobiera rezultat walki
                if(fightWindow.ShowDialog() == DialogResult.OK)
                {
                    life = fightWindow.PokemonLife;
                    experience += fightWindow.MonsterExperience;
                }
            }
        }
    }
}
