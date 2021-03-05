
namespace SwordAndSandals
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.buttonShowStuff = new System.Windows.Forms.Button();
            this.dataGridViewWeapons = new System.Windows.Forms.DataGridView();
            this.dataGridViewArmors = new System.Windows.Forms.DataGridView();
            this.dataGridViewChampionWeapons = new System.Windows.Forms.DataGridView();
            this.dataGridViewChampionArmors = new System.Windows.Forms.DataGridView();
            this.buttonWeaponImprove = new System.Windows.Forms.Button();
            this.buttonArmorImprove = new System.Windows.Forms.Button();
            this.labelChampionGold = new System.Windows.Forms.Label();
            this.textBoxChampionGold = new System.Windows.Forms.TextBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.textBoxBuyArmor = new System.Windows.Forms.TextBox();
            this.labelBuyArmor = new System.Windows.Forms.Label();
            this.labelBuyWeapon = new System.Windows.Forms.Label();
            this.textBoxBuyWeapon = new System.Windows.Forms.TextBox();
            this.buttonBuyWeapon = new System.Windows.Forms.Button();
            this.buttonBuyArmor = new System.Windows.Forms.Button();
            this.buttonChangeWeapon = new System.Windows.Forms.Button();
            this.buttonChangeArmor = new System.Windows.Forms.Button();
            this.textBoxCurrentWeapon = new System.Windows.Forms.TextBox();
            this.textBoxCurrentArmor = new System.Windows.Forms.TextBox();
            this.buttonDeleteWeapon = new System.Windows.Forms.Button();
            this.buttonDeleteArmor = new System.Windows.Forms.Button();
            this.pictureBoxBackGroundShop = new System.Windows.Forms.PictureBox();
            this.pictureBoxSmith = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampionWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampionArmors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGroundShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmith)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowStuff
            // 
            this.buttonShowStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowStuff.Location = new System.Drawing.Point(942, 308);
            this.buttonShowStuff.Name = "buttonShowStuff";
            this.buttonShowStuff.Size = new System.Drawing.Size(183, 47);
            this.buttonShowStuff.TabIndex = 0;
            this.buttonShowStuff.Text = "Pokaż ofertę";
            this.buttonShowStuff.UseVisualStyleBackColor = true;
            this.buttonShowStuff.Click += new System.EventHandler(this.buttonShowStuff_Click);
            // 
            // dataGridViewWeapons
            // 
            this.dataGridViewWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeapons.Location = new System.Drawing.Point(798, 482);
            this.dataGridViewWeapons.Name = "dataGridViewWeapons";
            this.dataGridViewWeapons.Size = new System.Drawing.Size(436, 115);
            this.dataGridViewWeapons.TabIndex = 1;
            // 
            // dataGridViewArmors
            // 
            this.dataGridViewArmors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArmors.Location = new System.Drawing.Point(798, 361);
            this.dataGridViewArmors.Name = "dataGridViewArmors";
            this.dataGridViewArmors.Size = new System.Drawing.Size(436, 115);
            this.dataGridViewArmors.TabIndex = 2;
            // 
            // dataGridViewChampionWeapons
            // 
            this.dataGridViewChampionWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChampionWeapons.Location = new System.Drawing.Point(798, 187);
            this.dataGridViewChampionWeapons.Name = "dataGridViewChampionWeapons";
            this.dataGridViewChampionWeapons.Size = new System.Drawing.Size(436, 115);
            this.dataGridViewChampionWeapons.TabIndex = 3;
            // 
            // dataGridViewChampionArmors
            // 
            this.dataGridViewChampionArmors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChampionArmors.Location = new System.Drawing.Point(798, 66);
            this.dataGridViewChampionArmors.Name = "dataGridViewChampionArmors";
            this.dataGridViewChampionArmors.Size = new System.Drawing.Size(436, 115);
            this.dataGridViewChampionArmors.TabIndex = 4;
            // 
            // buttonWeaponImprove
            // 
            this.buttonWeaponImprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWeaponImprove.Location = new System.Drawing.Point(12, 530);
            this.buttonWeaponImprove.Name = "buttonWeaponImprove";
            this.buttonWeaponImprove.Size = new System.Drawing.Size(167, 60);
            this.buttonWeaponImprove.TabIndex = 6;
            this.buttonWeaponImprove.Text = "Ulepsz broń";
            this.buttonWeaponImprove.UseVisualStyleBackColor = true;
            this.buttonWeaponImprove.Click += new System.EventHandler(this.buttonWeaponImprove_Click);
            // 
            // buttonArmorImprove
            // 
            this.buttonArmorImprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArmorImprove.Location = new System.Drawing.Point(185, 530);
            this.buttonArmorImprove.Name = "buttonArmorImprove";
            this.buttonArmorImprove.Size = new System.Drawing.Size(167, 60);
            this.buttonArmorImprove.TabIndex = 7;
            this.buttonArmorImprove.Text = "Ulepsz zbroje";
            this.buttonArmorImprove.UseVisualStyleBackColor = true;
            this.buttonArmorImprove.Click += new System.EventHandler(this.buttonArmorImprove_Click);
            // 
            // labelChampionGold
            // 
            this.labelChampionGold.AutoSize = true;
            this.labelChampionGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChampionGold.Location = new System.Drawing.Point(593, 12);
            this.labelChampionGold.Name = "labelChampionGold";
            this.labelChampionGold.Size = new System.Drawing.Size(121, 24);
            this.labelChampionGold.TabIndex = 8;
            this.labelChampionGold.Text = "Twoje złoto";
            // 
            // textBoxChampionGold
            // 
            this.textBoxChampionGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChampionGold.Location = new System.Drawing.Point(591, 39);
            this.textBoxChampionGold.Name = "textBoxChampionGold";
            this.textBoxChampionGold.Size = new System.Drawing.Size(123, 31);
            this.textBoxChampionGold.TabIndex = 9;
            this.textBoxChampionGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // textBoxBuyArmor
            // 
            this.textBoxBuyArmor.Location = new System.Drawing.Point(559, 384);
            this.textBoxBuyArmor.Name = "textBoxBuyArmor";
            this.textBoxBuyArmor.Size = new System.Drawing.Size(195, 20);
            this.textBoxBuyArmor.TabIndex = 10;
            // 
            // labelBuyArmor
            // 
            this.labelBuyArmor.AutoSize = true;
            this.labelBuyArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuyArmor.Location = new System.Drawing.Point(562, 361);
            this.labelBuyArmor.Name = "labelBuyArmor";
            this.labelBuyArmor.Size = new System.Drawing.Size(192, 20);
            this.labelBuyArmor.TabIndex = 11;
            this.labelBuyArmor.Text = "Wpisz nazwę pancerza";
            // 
            // labelBuyWeapon
            // 
            this.labelBuyWeapon.AutoSize = true;
            this.labelBuyWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuyWeapon.Location = new System.Drawing.Point(576, 187);
            this.labelBuyWeapon.Name = "labelBuyWeapon";
            this.labelBuyWeapon.Size = new System.Drawing.Size(158, 20);
            this.labelBuyWeapon.TabIndex = 12;
            this.labelBuyWeapon.Text = "Wpisz nazwę broni";
            // 
            // textBoxBuyWeapon
            // 
            this.textBoxBuyWeapon.Location = new System.Drawing.Point(559, 210);
            this.textBoxBuyWeapon.Name = "textBoxBuyWeapon";
            this.textBoxBuyWeapon.Size = new System.Drawing.Size(195, 20);
            this.textBoxBuyWeapon.TabIndex = 13;
            // 
            // buttonBuyWeapon
            // 
            this.buttonBuyWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuyWeapon.Location = new System.Drawing.Point(559, 236);
            this.buttonBuyWeapon.Name = "buttonBuyWeapon";
            this.buttonBuyWeapon.Size = new System.Drawing.Size(195, 36);
            this.buttonBuyWeapon.TabIndex = 14;
            this.buttonBuyWeapon.Text = "Kup broń";
            this.buttonBuyWeapon.UseVisualStyleBackColor = true;
            this.buttonBuyWeapon.Click += new System.EventHandler(this.buttonBuyWeapon_Click);
            // 
            // buttonBuyArmor
            // 
            this.buttonBuyArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuyArmor.Location = new System.Drawing.Point(559, 410);
            this.buttonBuyArmor.Name = "buttonBuyArmor";
            this.buttonBuyArmor.Size = new System.Drawing.Size(195, 37);
            this.buttonBuyArmor.TabIndex = 15;
            this.buttonBuyArmor.Text = "Kup pancerz";
            this.buttonBuyArmor.UseVisualStyleBackColor = true;
            this.buttonBuyArmor.Click += new System.EventHandler(this.buttonBuyArmor_Click);
            // 
            // buttonChangeWeapon
            // 
            this.buttonChangeWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeWeapon.Location = new System.Drawing.Point(12, 464);
            this.buttonChangeWeapon.Name = "buttonChangeWeapon";
            this.buttonChangeWeapon.Size = new System.Drawing.Size(167, 60);
            this.buttonChangeWeapon.TabIndex = 16;
            this.buttonChangeWeapon.Text = "Zmień broń";
            this.buttonChangeWeapon.UseVisualStyleBackColor = true;
            this.buttonChangeWeapon.Click += new System.EventHandler(this.buttonChangeWeapon_Click);
            // 
            // buttonChangeArmor
            // 
            this.buttonChangeArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeArmor.Location = new System.Drawing.Point(186, 464);
            this.buttonChangeArmor.Name = "buttonChangeArmor";
            this.buttonChangeArmor.Size = new System.Drawing.Size(167, 60);
            this.buttonChangeArmor.TabIndex = 17;
            this.buttonChangeArmor.Text = "Zmień zbroje";
            this.buttonChangeArmor.UseVisualStyleBackColor = true;
            this.buttonChangeArmor.Click += new System.EventHandler(this.buttonChangeArmor_Click);
            // 
            // textBoxCurrentWeapon
            // 
            this.textBoxCurrentWeapon.Location = new System.Drawing.Point(13, 374);
            this.textBoxCurrentWeapon.Name = "textBoxCurrentWeapon";
            this.textBoxCurrentWeapon.Size = new System.Drawing.Size(167, 20);
            this.textBoxCurrentWeapon.TabIndex = 18;
            // 
            // textBoxCurrentArmor
            // 
            this.textBoxCurrentArmor.Location = new System.Drawing.Point(186, 374);
            this.textBoxCurrentArmor.Name = "textBoxCurrentArmor";
            this.textBoxCurrentArmor.Size = new System.Drawing.Size(167, 20);
            this.textBoxCurrentArmor.TabIndex = 19;
            // 
            // buttonDeleteWeapon
            // 
            this.buttonDeleteWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteWeapon.Location = new System.Drawing.Point(13, 400);
            this.buttonDeleteWeapon.Name = "buttonDeleteWeapon";
            this.buttonDeleteWeapon.Size = new System.Drawing.Size(167, 60);
            this.buttonDeleteWeapon.TabIndex = 20;
            this.buttonDeleteWeapon.Text = "Usuń broń";
            this.buttonDeleteWeapon.UseVisualStyleBackColor = true;
            this.buttonDeleteWeapon.Click += new System.EventHandler(this.buttonDeleteWeapon_Click);
            // 
            // buttonDeleteArmor
            // 
            this.buttonDeleteArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteArmor.Location = new System.Drawing.Point(186, 400);
            this.buttonDeleteArmor.Name = "buttonDeleteArmor";
            this.buttonDeleteArmor.Size = new System.Drawing.Size(166, 60);
            this.buttonDeleteArmor.TabIndex = 21;
            this.buttonDeleteArmor.Text = "Usuń zbroje";
            this.buttonDeleteArmor.UseVisualStyleBackColor = true;
            this.buttonDeleteArmor.Click += new System.EventHandler(this.buttonDeleteArmor_Click);
            // 
            // pictureBoxBackGroundShop
            // 
            this.pictureBoxBackGroundShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackGroundShop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGroundShop.Image")));
            this.pictureBoxBackGroundShop.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGroundShop.Name = "pictureBoxBackGroundShop";
            this.pictureBoxBackGroundShop.Size = new System.Drawing.Size(1242, 613);
            this.pictureBoxBackGroundShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGroundShop.TabIndex = 22;
            this.pictureBoxBackGroundShop.TabStop = false;
            // 
            // pictureBoxSmith
            // 
            this.pictureBoxSmith.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSmith.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSmith.Image")));
            this.pictureBoxSmith.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxSmith.Name = "pictureBoxSmith";
            this.pictureBoxSmith.Size = new System.Drawing.Size(547, 479);
            this.pictureBoxSmith.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSmith.TabIndex = 23;
            this.pictureBoxSmith.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(954, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Twój ekwipunek";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteArmor);
            this.Controls.Add(this.buttonDeleteWeapon);
            this.Controls.Add(this.textBoxCurrentArmor);
            this.Controls.Add(this.textBoxCurrentWeapon);
            this.Controls.Add(this.buttonChangeArmor);
            this.Controls.Add(this.buttonChangeWeapon);
            this.Controls.Add(this.buttonBuyArmor);
            this.Controls.Add(this.buttonBuyWeapon);
            this.Controls.Add(this.textBoxBuyWeapon);
            this.Controls.Add(this.labelBuyWeapon);
            this.Controls.Add(this.labelBuyArmor);
            this.Controls.Add(this.textBoxBuyArmor);
            this.Controls.Add(this.textBoxChampionGold);
            this.Controls.Add(this.labelChampionGold);
            this.Controls.Add(this.buttonArmorImprove);
            this.Controls.Add(this.buttonWeaponImprove);
            this.Controls.Add(this.dataGridViewChampionArmors);
            this.Controls.Add(this.dataGridViewChampionWeapons);
            this.Controls.Add(this.dataGridViewArmors);
            this.Controls.Add(this.dataGridViewWeapons);
            this.Controls.Add(this.buttonShowStuff);
            this.Controls.Add(this.pictureBoxSmith);
            this.Controls.Add(this.pictureBoxBackGroundShop);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArmors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampionWeapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampionArmors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGroundShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmith)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowStuff;
        private System.Windows.Forms.DataGridView dataGridViewWeapons;
        private System.Windows.Forms.DataGridView dataGridViewArmors;
        private System.Windows.Forms.DataGridView dataGridViewChampionWeapons;
        private System.Windows.Forms.DataGridView dataGridViewChampionArmors;
        private System.Windows.Forms.Button buttonWeaponImprove;
        private System.Windows.Forms.Button buttonArmorImprove;
        private System.Windows.Forms.Label labelChampionGold;
        private System.Windows.Forms.TextBox textBoxChampionGold;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.TextBox textBoxBuyArmor;
        private System.Windows.Forms.Label labelBuyArmor;
        private System.Windows.Forms.Label labelBuyWeapon;
        private System.Windows.Forms.TextBox textBoxBuyWeapon;
        private System.Windows.Forms.Button buttonBuyWeapon;
        private System.Windows.Forms.Button buttonBuyArmor;
        private System.Windows.Forms.Button buttonChangeWeapon;
        private System.Windows.Forms.Button buttonChangeArmor;
        private System.Windows.Forms.TextBox textBoxCurrentWeapon;
        private System.Windows.Forms.TextBox textBoxCurrentArmor;
        private System.Windows.Forms.Button buttonDeleteWeapon;
        private System.Windows.Forms.Button buttonDeleteArmor;
        private System.Windows.Forms.PictureBox pictureBoxBackGroundShop;
        private System.Windows.Forms.PictureBox pictureBoxSmith;
        private System.Windows.Forms.Label label1;
    }
}