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
    public partial class City : Form
    {
        // Nasz bohater
        public Champion champion = new Champion();

        // Okno areny
        Arena arena;

        // Okno sklepu
        Shop shop;

        // Okno bossa
        End end;

        // Lista przeciwników
        public List<Enemy> enemys = new List<Enemy>();

        public City()
        {
            //Dodanie początkowych przeciwników
            enemys.Add(new Enemy(1));
            enemys.Add(new Enemy(2));
            enemys.Add(new Enemy(3));

            InitializeComponent();
            // Przeźroczyste tło bohatera
            pictureBoxChampion.Parent = pictureBoxCityBackground;
        }

        /// <summary>
        /// Otwiera okno areny, w ktorym walczymy zeby zdobyć doświadczenie
        /// oraz złoto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArena_Click(object sender, EventArgs e)
        {
            // Walka kosztuje nas 30 energii
            champion.Energy -= 30;
            using (arena = new Arena(this))
            {
                // Tworzy zmienną przeciwnika
                Enemy enemyFound;
                // Losujemy statystyki przeciwnika
                enemyFound = enemys.Where(x => x.Lvl == 1).FirstOrDefault();
                enemyFound.PickEnemy();

                enemyFound = enemys.Where(x => x.Lvl == 2).FirstOrDefault();
                enemyFound.PickEnemy();

                enemyFound = enemys.Where(x => x.Lvl == 3).FirstOrDefault();
                enemyFound.PickEnemy();
                // Pokazujemy okno areny
                arena.ShowDialog();
            }
        }
        /// <summary>
        /// Funkcja odświeżająca kontrolki
        /// </summary>
        private void RefreshControls()
        {
            textBoxLife.Text = champion.Hp.ToString();
            textBoxDamage.Text = champion.Damage.ToString();
            textBoxDefence.Text = champion.Defence.ToString();
            textBoxEnergy.Text = champion.Energy.ToString();
            textBoxExperience.Text = champion.Experience.ToString();
            textBoxLvl.Text = champion.Lvl.ToString();
            textBoxGold.Text = champion.Gold.ToString();
            textBoxChampionNick.Text = champion.Name.ToString();
        }
        /// <summary>
        /// Timer odpowiadający za czas gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Uwzględnienie obrażeń i pancerza z przedmiotu
            if (champion.currentWeapon != null && champion.currentArmor != null)
            {
                champion.Damage = champion.BaseDamage + champion.currentWeapon.Damage;
                champion.Defence = champion.BaseDefence + champion.currentArmor.Defence;
            }
            // Zdobycie poziomu przez bohatera
            if (champion.Experience >= champion.ExpToLvlUp) champion.LvlUp();
            // Odświeżenie kontrolek
            RefreshControls();
            // Wzrost energii z czasem
            if (champion.Energy < 100) champion.Energy++;
        }
        /// <summary>
        /// Przycisk odpowiada za otwarcie okna bossa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShop_Click(object sender, EventArgs e)
        {
            using (shop = new Shop(this))
            {
                // Pokazujemy okno sklepu
                shop.ShowDialog();
            }
        }
        /// <summary>
        /// Przycisk wymienia złoto za życie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeed_Click(object sender, EventArgs e)
        {
            // Jeżeli mamy złoto, to możemy je wymienić za życie
            if (champion.Gold > 0)
            {
                if (champion.Hp < 60)
                {
                    champion.Hp += 40;
                }
                else champion.Hp = 100;
                champion.Gold -= 1;
            }
        }
        /// <summary>
        /// Przycisk przenosi nas do okna bossa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLastBoss_Click(object sender, EventArgs e)
        {
            using (end = new End(this))
            {
                // pokazuje okno końcowe
                end.ShowDialog();
            }
        }
        /// <summary>
        /// Przycisk służy do wymiany energii na złoto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click(object sender, EventArgs e)
        {
            // Wymieniamy energię za złoto
            if (champion.Energy == 100)
            {
                champion.Energy = 0;
                champion.Gold += 1;
            }
        }
        /// <summary>
        /// Zmień płeć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeSex_Click(object sender, EventArgs e)
        {
            // Zdjęcie boahtera w zależności od płci
            if (champion.Female == true)
            {
                pictureBoxChampion.Image = SwordAndSandals.Properties.Resources.mmm;
            }
            else pictureBoxChampion.Image = SwordAndSandals.Properties.Resources.champion;
            // Zmieniamy zmienną płci i nazwe bohatera
            champion.ChangeSex();
        }
    }
}
