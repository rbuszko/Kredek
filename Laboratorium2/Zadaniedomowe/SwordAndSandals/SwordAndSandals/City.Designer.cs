
namespace SwordAndSandals
{
    partial class City
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(City));
            this.textBoxChampionNick = new System.Windows.Forms.TextBox();
            this.buttonArena = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.textBoxGold = new System.Windows.Forms.TextBox();
            this.labelGold = new System.Windows.Forms.Label();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.textBoxLvl = new System.Windows.Forms.TextBox();
            this.textBoxDefence = new System.Windows.Forms.TextBox();
            this.textBoxDamage = new System.Windows.Forms.TextBox();
            this.textBoxEnergy = new System.Windows.Forms.TextBox();
            this.textBoxLife = new System.Windows.Forms.TextBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelLvl = new System.Windows.Forms.Label();
            this.labelDefence = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.labelLife = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonLastBoss = new System.Windows.Forms.Button();
            this.pictureBoxCityBackground = new System.Windows.Forms.PictureBox();
            this.pictureBoxChampion = new System.Windows.Forms.PictureBox();
            this.buttonWork = new System.Windows.Forms.Button();
            this.buttonChangeSex = new System.Windows.Forms.Button();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCityBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampion)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxChampionNick
            // 
            this.textBoxChampionNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChampionNick.Location = new System.Drawing.Point(625, 513);
            this.textBoxChampionNick.Name = "textBoxChampionNick";
            this.textBoxChampionNick.Size = new System.Drawing.Size(181, 24);
            this.textBoxChampionNick.TabIndex = 0;
            this.textBoxChampionNick.Text = "xXKozakPLXx";
            this.textBoxChampionNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonArena
            // 
            this.buttonArena.BackColor = System.Drawing.Color.Transparent;
            this.buttonArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonArena.Location = new System.Drawing.Point(776, 144);
            this.buttonArena.Name = "buttonArena";
            this.buttonArena.Size = new System.Drawing.Size(179, 59);
            this.buttonArena.TabIndex = 1;
            this.buttonArena.Text = "Walcz na arenie";
            this.buttonArena.UseVisualStyleBackColor = false;
            this.buttonArena.Click += new System.EventHandler(this.buttonArena_Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.textBoxGold);
            this.groupBoxStatus.Controls.Add(this.labelGold);
            this.groupBoxStatus.Controls.Add(this.textBoxExperience);
            this.groupBoxStatus.Controls.Add(this.textBoxLvl);
            this.groupBoxStatus.Controls.Add(this.textBoxDefence);
            this.groupBoxStatus.Controls.Add(this.textBoxDamage);
            this.groupBoxStatus.Controls.Add(this.textBoxEnergy);
            this.groupBoxStatus.Controls.Add(this.textBoxLife);
            this.groupBoxStatus.Controls.Add(this.labelExperience);
            this.groupBoxStatus.Controls.Add(this.labelLvl);
            this.groupBoxStatus.Controls.Add(this.labelDefence);
            this.groupBoxStatus.Controls.Add(this.labelDamage);
            this.groupBoxStatus.Controls.Add(this.labelEnergy);
            this.groupBoxStatus.Controls.Add(this.labelLife);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxStatus.Location = new System.Drawing.Point(12, 210);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(201, 338);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // textBoxGold
            // 
            this.textBoxGold.Location = new System.Drawing.Point(6, 305);
            this.textBoxGold.Name = "textBoxGold";
            this.textBoxGold.Size = new System.Drawing.Size(189, 22);
            this.textBoxGold.TabIndex = 13;
            this.textBoxGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(72, 286);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(46, 16);
            this.labelGold.TabIndex = 12;
            this.labelGold.Text = "Złoto";
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(6, 257);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(189, 22);
            this.textBoxExperience.TabIndex = 11;
            this.textBoxExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLvl
            // 
            this.textBoxLvl.Location = new System.Drawing.Point(6, 213);
            this.textBoxLvl.Name = "textBoxLvl";
            this.textBoxLvl.Size = new System.Drawing.Size(189, 22);
            this.textBoxLvl.TabIndex = 10;
            this.textBoxLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDefence
            // 
            this.textBoxDefence.Location = new System.Drawing.Point(6, 169);
            this.textBoxDefence.Name = "textBoxDefence";
            this.textBoxDefence.Size = new System.Drawing.Size(189, 22);
            this.textBoxDefence.TabIndex = 9;
            this.textBoxDefence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDamage
            // 
            this.textBoxDamage.Location = new System.Drawing.Point(6, 125);
            this.textBoxDamage.Name = "textBoxDamage";
            this.textBoxDamage.Size = new System.Drawing.Size(189, 22);
            this.textBoxDamage.TabIndex = 8;
            this.textBoxDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnergy
            // 
            this.textBoxEnergy.Location = new System.Drawing.Point(6, 81);
            this.textBoxEnergy.Name = "textBoxEnergy";
            this.textBoxEnergy.Size = new System.Drawing.Size(189, 22);
            this.textBoxEnergy.TabIndex = 7;
            this.textBoxEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLife
            // 
            this.textBoxLife.Location = new System.Drawing.Point(6, 37);
            this.textBoxLife.Name = "textBoxLife";
            this.textBoxLife.Size = new System.Drawing.Size(189, 22);
            this.textBoxLife.TabIndex = 6;
            this.textBoxLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(46, 238);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(113, 16);
            this.labelExperience.TabIndex = 5;
            this.labelExperience.Text = "Doświadczenie";
            // 
            // labelLvl
            // 
            this.labelLvl.AutoSize = true;
            this.labelLvl.Location = new System.Drawing.Point(85, 194);
            this.labelLvl.Name = "labelLvl";
            this.labelLvl.Size = new System.Drawing.Size(28, 16);
            this.labelLvl.TabIndex = 4;
            this.labelLvl.Text = "Lvl";
            // 
            // labelDefence
            // 
            this.labelDefence.AutoSize = true;
            this.labelDefence.Location = new System.Drawing.Point(72, 150);
            this.labelDefence.Name = "labelDefence";
            this.labelDefence.Size = new System.Drawing.Size(59, 16);
            this.labelDefence.TabIndex = 3;
            this.labelDefence.Text = "Obrona";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Location = new System.Drawing.Point(61, 106);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(79, 16);
            this.labelDamage.TabIndex = 2;
            this.labelDamage.Text = "Obrażenia";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Location = new System.Drawing.Point(72, 62);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(62, 16);
            this.labelEnergy.TabIndex = 1;
            this.labelEnergy.Text = "Energia";
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.Location = new System.Drawing.Point(72, 18);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(46, 16);
            this.labelLife.TabIndex = 0;
            this.labelLife.Text = "Życie";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 500;
            this.timerTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonShop
            // 
            this.buttonShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShop.Location = new System.Drawing.Point(1047, 205);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(129, 59);
            this.buttonShop.TabIndex = 3;
            this.buttonShop.Text = "Zbrojmistrz";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFeed.Location = new System.Drawing.Point(208, 145);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(300, 59);
            this.buttonFeed.TabIndex = 4;
            this.buttonFeed.Text = "Najedz się (-1 złota, +30hp)";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonLastBoss
            // 
            this.buttonLastBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLastBoss.Location = new System.Drawing.Point(18, 25);
            this.buttonLastBoss.Name = "buttonLastBoss";
            this.buttonLastBoss.Size = new System.Drawing.Size(209, 58);
            this.buttonLastBoss.TabIndex = 5;
            this.buttonLastBoss.Text = "Walcz z bossem";
            this.buttonLastBoss.UseVisualStyleBackColor = true;
            this.buttonLastBoss.Click += new System.EventHandler(this.buttonLastBoss_Click);
            // 
            // pictureBoxCityBackground
            // 
            this.pictureBoxCityBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCityBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCityBackground.Image")));
            this.pictureBoxCityBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCityBackground.Name = "pictureBoxCityBackground";
            this.pictureBoxCityBackground.Size = new System.Drawing.Size(1220, 560);
            this.pictureBoxCityBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCityBackground.TabIndex = 6;
            this.pictureBoxCityBackground.TabStop = false;
            // 
            // pictureBoxChampion
            // 
            this.pictureBoxChampion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChampion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChampion.Image")));
            this.pictureBoxChampion.Location = new System.Drawing.Point(568, 215);
            this.pictureBoxChampion.Name = "pictureBoxChampion";
            this.pictureBoxChampion.Size = new System.Drawing.Size(277, 322);
            this.pictureBoxChampion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxChampion.TabIndex = 7;
            this.pictureBoxChampion.TabStop = false;
            // 
            // buttonWork
            // 
            this.buttonWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWork.Location = new System.Drawing.Point(936, 425);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(240, 59);
            this.buttonWork.TabIndex = 8;
            this.buttonWork.Text = "    Pracuj w polu      (-100 energii, +1 złota)";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // buttonChangeSex
            // 
            this.buttonChangeSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeSex.Location = new System.Drawing.Point(424, 479);
            this.buttonChangeSex.Name = "buttonChangeSex";
            this.buttonChangeSex.Size = new System.Drawing.Size(120, 58);
            this.buttonChangeSex.TabIndex = 9;
            this.buttonChangeSex.Text = "Zmień płeć";
            this.buttonChangeSex.UseVisualStyleBackColor = true;
            this.buttonChangeSex.Click += new System.EventHandler(this.buttonChangeSex_Click);
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 560);
            this.Controls.Add(this.buttonChangeSex);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.pictureBoxChampion);
            this.Controls.Add(this.buttonLastBoss);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.buttonArena);
            this.Controls.Add(this.textBoxChampionNick);
            this.Controls.Add(this.pictureBoxCityBackground);
            this.Name = "City";
            this.Text = "Miasto";
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCityBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChampionNick;
        private System.Windows.Forms.Button buttonArena;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.TextBox textBoxLvl;
        private System.Windows.Forms.TextBox textBoxDefence;
        private System.Windows.Forms.TextBox textBoxDamage;
        private System.Windows.Forms.TextBox textBoxEnergy;
        private System.Windows.Forms.TextBox textBoxLife;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelLvl;
        private System.Windows.Forms.Label labelDefence;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.TextBox textBoxGold;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Button buttonLastBoss;
        private System.Windows.Forms.PictureBox pictureBoxCityBackground;
        private System.Windows.Forms.PictureBox pictureBoxChampion;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Button buttonChangeSex;
    }
}

