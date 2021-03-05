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
    public partial class Walka : Form
    {
        // Atak naszego pokemona
        public int pokemonAttack;
        // Obrona naszego pokemona
        public int pokemonDefence;
        // Życie naszego pokemona
        public int pokemonLife;
        // Atak potwora
        public int monsterAttack;
        // Obrona potwora
        public int monsterDefence;

        // Życie potwora
        int monsterLife = 100;
        // Doświadczenie zdobyte za zabicie potwora
        int monsterExperience = 0;

        public Walka()
        {
            InitializeComponent();

            // Początkowe życie bohaterów
            textBoxPokemonLife.Text = pokemonLife.ToString();
            textBoxMonsterLife.Text = monsterLife.ToString();
        }
        /// <summary>
        /// Funkcja odpowiadająca za czas walki
        /// służy do pokazania obecnego życia i obsługuje atak
        /// potwora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWalki_Tick(object sender, EventArgs e)
        {

            // Wyświetla aktualne życie
            textBoxPokemonLife.Text = pokemonLife.ToString();
            textBoxMonsterLife.Text = monsterLife.ToString();

            // Funkcja ataku potwora, określa ilość obrażeń jakie zadaje potwór
            if (pokemonLife > monsterAttack - pokemonDefence)
            {
                if (monsterAttack > pokemonDefence)
                    pokemonLife = pokemonLife - (monsterAttack - pokemonDefence);
                else pokemonLife--;
            }
            // Oznacza to naszą przegraną, zatrzymuje stoper, wyświetla wiadomość
            // Zamyka okno
            else
            {
                pokemonLife = 0;
                timerWalki.Stop();
                MessageBox.Show("Przegrałeś!!!", "Wynik walki...", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Definicja przycisku atak, w przypadku gdy wygramy wyświetla informacje
        /// Przekazuje zdobyte doświadczenie do pokemona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            // Funkcja określa obrażenia zadane przez naszego pokemona
            if (monsterLife > pokemonAttack - monsterDefence)
            {
                if (pokemonAttack > monsterDefence && pokemonAttack > monsterAttack)
                    monsterLife = monsterLife - (pokemonAttack - monsterAttack);
                else if (pokemonAttack > monsterDefence && pokemonAttack < monsterAttack)
                    monsterLife = monsterLife + (pokemonAttack - monsterAttack);
                else monsterLife--;
            }
            // Oznacza wygraną, przypisuje doświadczenie, wyświetla komunikat, zatrzymuje stoper
            else
            {
                monsterLife = 0;
                timerWalki.Stop();
                MessageBox.Show("Wygrałeś!!!", "Wynik walki...", MessageBoxButtons.OK);
                if ((pokemonAttack + pokemonDefence) > (monsterAttack + monsterDefence))
                {
                    monsterExperience = 10;
                }
                else
                {
                    monsterExperience = - pokemonAttack - pokemonDefence + monsterAttack + monsterDefence;
                }
                DialogResult = DialogResult.OK;
            }
        } 
        // Funkcja zwraca życie pokemona
        public int PokemonLife
        {
            get { return pokemonLife; }
        }
        // Funkcja zwraca ilość otrzymanego expa
        public int MonsterExperience
        {
            get { return monsterExperience; }
        }
    }
}
