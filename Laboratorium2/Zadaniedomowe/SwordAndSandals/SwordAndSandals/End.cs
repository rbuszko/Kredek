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
    public partial class End : Form
    {
        /// <summary>
        /// Instancja miasta w celu uzyskania dostępu do
        /// naszego bohatera
        /// </summary>
        private City city;
        /// <summary>
        /// Instancja ostatniego bossa
        /// </summary>
        LastBoss lastBoss = new LastBoss();
        /// <summary>
        /// Konstruktor parametryczny areny z dostępem do miasta
        /// </summary>
        /// <param name="city"></param>
        public End(City city)
        {
            this.city = city;
            InitializeComponent();
            // Tło bossa na przeźroczysty
            pictureBoxBoss.Parent = pictureBoxBossBackground;
        }
        /// <summary>
        /// Funkcja zegara okna bossa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnd_Tick(object sender, EventArgs e)
        {
            // Sprawdzenie wyniku walki
            Result();

            // Boss regeneruje się w trakcie walki
            if (lastBoss.Hp < 500) lastBoss.Hp += lastBoss.Regeneration;
            if (lastBoss.Damage >= city.champion.Defence) city.champion.Hp -= 10;
            if (lastBoss.Damage < city.champion.Defence) city.champion.Hp -= 2;

            // Refresh okienek
            textBoxBossLife.Text = lastBoss.Hp.ToString();
            textBoxChampionLife.Text = city.champion.Hp.ToString();
        }
        /// <summary>
        /// Przycisk odpowiada za rozpoczęcie walki, odświeża wartości, rozpoczyna walkę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFight_Click(object sender, EventArgs e)
        {
            // Włącza timer
            timerEnd.Start();
            // Pokazuje życie i nazwy opponentów
            textBoxBossLife.Text = lastBoss.Hp.ToString();
            textBoxChampionLife.Text = city.champion.Hp.ToString();
            labelBossName.Text = lastBoss.Name;
            textBoxChampionName.Text = city.champion.Name;
            // Chowa przycisk 
            buttonFight.Hide();
            // Wyciąga przycisk ataku
            buttonDealDmg.Visible = true;
        }

        /// <summary>
        /// Zakończenie pojedynku, true wygrana, false przegrana
        /// </summary>
        void Result()
        {
            // Gracz wygrał
            if (lastBoss.Hp <= 0)
            {
                // Zatrzymujemy stoper
                timerEnd.Stop();
                // Wyświetlamy przycisk zakończ
                buttonEnd.Visible = true;
                // Chowamy przycisk ataku
                buttonDealDmg.Hide();
                // Wiadomość dla wygranego
                MessageBox.Show("GRATULACJĘ UDAŁO CI SIĘ POKONAĆ OSTATNIEGO BOSSA," +
                    " jeżeli chcesz to mozesz grać dalej", "Zło zostało pokonane!", MessageBoxButtons.OK);
            }
            // Przeciwnik wygrał
            else if (city.champion.Hp <= 0)
            {
                // Zatrzymujemy stoper
                timerEnd.Stop();
                // Gracz ma 1 życia po przegranej
                city.champion.Hp = 1;
                // Wyświetlamy przycisk zakończ
                buttonEnd.Visible = true;
                // Chowamy przycisk ataku
                buttonDealDmg.Hide();
            }
        }

        /// <summary>
        /// Przycisk odpowiada za obrażenia jakie zadajemy przeciwnikowi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDealDmg_Click(object sender, EventArgs e)
        {
            // Sprawdzenie wyniku walki
            Result();
            // Dmg w bossa
            if (lastBoss.Defence <= city.champion.Damage) lastBoss.Hp -= city.champion.Damage - lastBoss.Defence + 10;
            else lastBoss.Hp -= 10;
        }
        /// <summary>
        ///  Przycisk wyjścia z okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
