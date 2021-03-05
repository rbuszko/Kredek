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
    public partial class Shop : Form
    {
        /// <summary>
        /// Instancja miasta w celu uzyskania dostępu do
        /// naszego bohatera
        /// </summary>
        private City city;

        // Lista broni
        public List<Weapon> weapons = new List<Weapon>();

        // Lista zbroi
        public List<Armor> armors = new List<Armor>();

        // Stworzenie obiektu klasy random, do wprowadzenia
        // elementów losowych w grze
        Random usefulNumber = new Random();

        public Shop(City city)
        {
            this.city = city;
            InitializeComponent();
            // Tło kowala na transparentny
            pictureBoxSmith.Parent = pictureBoxBackGroundShop;
        }

        /// <summary>
        /// Dodaje przedmioty do oferty, cena do jakości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowStuff_Click(object sender, EventArgs e)
        {
            // Dodanie broni do sklepu
            weapons.Add(new Weapon("Miecz słabiusi", 10, 10));
            weapons.Add(new Weapon("Miecz średniak", 15, 15));
            weapons.Add(new Weapon("Miecz mocarny", 20, 20));

            // Dodanie zbroi do sklepu
            armors.Add(new Armor("Zbroja słabiusia", 10, 10));
            armors.Add(new Armor("Zbroja średnia", 15, 15));
            armors.Add(new Armor("Zbroja mocarna", 20, 20));

            // Dodanie danych do Tabelki
            dataGridViewWeapons.DataSource = weapons;
            dataGridViewArmors.DataSource = armors;
        }
        /// <summary>
        /// Ulepsza noszoną przez nas broń, każde ulepszenie kosztuje tyle co cena broni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponImprove_Click(object sender, EventArgs e)
        {
            // Znaleziona broń
            Weapon weaponFound = weapons.Where(x => x.Name == textBoxBuyWeapon.Text).FirstOrDefault();
            // Zwiększamy statystyki broni w określony sposób za pieniądze
            if (city.champion.Gold > weaponFound.Price * weaponFound.Level)
            {
                weaponFound.Level += 1;
                weaponFound.Damage = weaponFound.BaseDamage * weaponFound.Level;
                city.champion.Gold -= weaponFound.Price * weaponFound.Level;
            }
            
        }
        /// <summary>
        /// Czas w sklepie do aktualizowania bieżących wyświetlanych wartości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            textBoxChampionGold.Text = city.champion.Gold.ToString();
            dataGridViewChampionWeapons.DataSource = typeof(List<Weapon>);
            dataGridViewChampionArmors.DataSource = typeof(List<Armor>);
            dataGridViewChampionArmors.DataSource = city.champion.armors;
            dataGridViewChampionWeapons.DataSource = city.champion.weapons;
        }
        /// <summary>
        /// Przycisk dodaj broń do naszego ekwipunku w zamian za złoto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWeapon_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie broni po nazwie
            Weapon weaponToBuy = weapons.Where(x => x.Name == textBoxBuyWeapon.Text).FirstOrDefault();
            // Jeżeli nas stać
            if (city.champion.Gold >= weaponToBuy.Price)
            {
                // Dodanie broni do ekwipunku
                city.champion.weapons.Add(weaponToBuy);
                // Wzamian za golda
                city.champion.Gold -= weaponToBuy.Price;
            }
        }
        /// <summary>
        /// Przycisk dodaje pancerz do naszego ekwipunkut w zamian za złoto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyArmor_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie broni po nazwie
            Armor armorToBuy = armors.Where(x => x.Name == textBoxBuyArmor.Text).FirstOrDefault();
            // Jeżeli nas stać
            if (city.champion.Gold >= armorToBuy.Price)
            {
                // Dodanie broni do ekwipunku
                city.champion.armors.Add(armorToBuy);
                // Wzamian za golda
                city.champion.Gold -= armorToBuy.Price;
            }
        }
        /// <summary>
        /// Zmieniamy broń w naszym ekwipunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeWeapon_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie broni po nazwie
            Weapon weaponToBuy = city.champion.weapons.Where(x => x.Name == textBoxCurrentWeapon.Text).FirstOrDefault();
            // Zmieniamy broń na podaną
            city.champion.currentWeapon = weaponToBuy;
        }
        /// <summary>
        /// Zmieniamy zbroję w naszym ekwipunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeArmor_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie broni po nazwie
            Armor armorToBuy = city.champion.armors.Where(x => x.Name == textBoxCurrentArmor.Text).FirstOrDefault();
            // Zmieniamy pancerz na podany
            city.champion.currentArmor = armorToBuy;
        }
        /// <summary>
        /// Ulepszamy zbroję każe ulepszenie o poziom kosztuje cena zbroi * poziom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArmorImprove_Click(object sender, EventArgs e)
        {
            // Znaleziona zbroja
            Armor armorFound = city.champion.armors.Where(x => x.Name == textBoxCurrentArmor.Text).FirstOrDefault();
            // Jeżeli nas stać to ulepszamy statystyki broni w zamian za złoto
            if (city.champion.Gold > armorFound.Price * armorFound.Level)
            {
                armorFound.Level += 1;
                armorFound.Defence = armorFound.BaseDefence * armorFound.Level;
                city.champion.Gold -= armorFound.Price * armorFound.Level;
            }
        }
        /// <summary>
        /// Funkcja usuwa broń z ekwipunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteWeapon_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie broni po nazwie
            Weapon weaponToDelete = city.champion.weapons.Where(x => x.Name == textBoxCurrentWeapon.Text).FirstOrDefault();

            // Warunek, żebyśmy mieli jakąś broń
            if (city.champion.weapons.Count > 1 && weaponToDelete != city.champion.currentWeapon)
            {
                // Usunięcie broni
                city.champion.weapons.Remove(weaponToDelete);
            }
        }
        /// <summary>
        /// Funkcja usuwa pancerz z ekwipunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteArmor_Click(object sender, EventArgs e)
        {
            // Wyszukiwanie pancerza po nazwie
            Armor armorToDelete = city.champion.armors.Where(x => x.Name == textBoxCurrentArmor.Text).FirstOrDefault();

            // Warunek żebyśmy mieli jakąś zbroję
            if (city.champion.weapons.Count > 1 && armorToDelete != city.champion.currentArmor)
            {
                // Usunięcie pancerza
                city.champion.armors.Remove(armorToDelete);
            }
        }
    }
}
