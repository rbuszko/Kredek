using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanBuszkoLab1
{
    public partial class FormAbout : Form
    {
        //Zmienna publiczna
        public string myName = "";
        public FormAbout()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja, która wywołuje się po zainicjalizowaniu okienka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelName.Text = myName;
        }
    }
}
