
namespace SwordAndSandals
{
    partial class Arena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arena));
            this.buttonEnemyLvl1 = new System.Windows.Forms.Button();
            this.buttonEnemyLvl2 = new System.Windows.Forms.Button();
            this.buttonEnemyLvl3 = new System.Windows.Forms.Button();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.textBoxEnemyLife = new System.Windows.Forms.TextBox();
            this.textBoxYourLife = new System.Windows.Forms.TextBox();
            this.timerFightTime = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStrongHit = new System.Windows.Forms.Button();
            this.buttonMediumHit = new System.Windows.Forms.Button();
            this.buttonLightHit = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.pictureBoxArenaBackground = new System.Windows.Forms.PictureBox();
            this.pictureBoxChampion = new System.Windows.Forms.PictureBox();
            this.textBoxChampionName = new System.Windows.Forms.TextBox();
            this.textBoxMonsterName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArenaBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnemyLvl1
            // 
            this.buttonEnemyLvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnemyLvl1.Location = new System.Drawing.Point(12, 524);
            this.buttonEnemyLvl1.Name = "buttonEnemyLvl1";
            this.buttonEnemyLvl1.Size = new System.Drawing.Size(165, 74);
            this.buttonEnemyLvl1.TabIndex = 2;
            this.buttonEnemyLvl1.Text = "Poziom 1";
            this.buttonEnemyLvl1.UseVisualStyleBackColor = true;
            this.buttonEnemyLvl1.Click += new System.EventHandler(this.buttonEnemyLvl1_Click);
            // 
            // buttonEnemyLvl2
            // 
            this.buttonEnemyLvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnemyLvl2.Location = new System.Drawing.Point(541, 524);
            this.buttonEnemyLvl2.Name = "buttonEnemyLvl2";
            this.buttonEnemyLvl2.Size = new System.Drawing.Size(165, 74);
            this.buttonEnemyLvl2.TabIndex = 3;
            this.buttonEnemyLvl2.Text = "Poziom 2";
            this.buttonEnemyLvl2.UseVisualStyleBackColor = true;
            this.buttonEnemyLvl2.Click += new System.EventHandler(this.buttonEnemyLvl2_Click);
            // 
            // buttonEnemyLvl3
            // 
            this.buttonEnemyLvl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnemyLvl3.Location = new System.Drawing.Point(1025, 524);
            this.buttonEnemyLvl3.Name = "buttonEnemyLvl3";
            this.buttonEnemyLvl3.Size = new System.Drawing.Size(165, 74);
            this.buttonEnemyLvl3.TabIndex = 4;
            this.buttonEnemyLvl3.Text = "Poziom 3";
            this.buttonEnemyLvl3.UseVisualStyleBackColor = true;
            this.buttonEnemyLvl3.Click += new System.EventHandler(this.buttonEnemyLvl3_Click);
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(615, 586);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // textBoxEnemyLife
            // 
            this.textBoxEnemyLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEnemyLife.Location = new System.Drawing.Point(12, 46);
            this.textBoxEnemyLife.Name = "textBoxEnemyLife";
            this.textBoxEnemyLife.Size = new System.Drawing.Size(220, 38);
            this.textBoxEnemyLife.TabIndex = 5;
            this.textBoxEnemyLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxYourLife
            // 
            this.textBoxYourLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxYourLife.Location = new System.Drawing.Point(970, 43);
            this.textBoxYourLife.Name = "textBoxYourLife";
            this.textBoxYourLife.Size = new System.Drawing.Size(220, 38);
            this.textBoxYourLife.TabIndex = 8;
            this.textBoxYourLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerFightTime
            // 
            this.timerFightTime.Tick += new System.EventHandler(this.timerFightTime_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(522, 195);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(208, 132);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStrongHit
            // 
            this.buttonStrongHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStrongHit.Location = new System.Drawing.Point(820, 195);
            this.buttonStrongHit.Name = "buttonStrongHit";
            this.buttonStrongHit.Size = new System.Drawing.Size(75, 23);
            this.buttonStrongHit.TabIndex = 10;
            this.buttonStrongHit.Text = "Mocny atak";
            this.buttonStrongHit.UseVisualStyleBackColor = true;
            this.buttonStrongHit.Visible = false;
            this.buttonStrongHit.Click += new System.EventHandler(this.buttonStrongHit_Click);
            // 
            // buttonMediumHit
            // 
            this.buttonMediumHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMediumHit.Location = new System.Drawing.Point(749, 262);
            this.buttonMediumHit.Name = "buttonMediumHit";
            this.buttonMediumHit.Size = new System.Drawing.Size(75, 23);
            this.buttonMediumHit.TabIndex = 11;
            this.buttonMediumHit.Text = "Średni atak";
            this.buttonMediumHit.UseVisualStyleBackColor = true;
            this.buttonMediumHit.Visible = false;
            this.buttonMediumHit.Click += new System.EventHandler(this.buttonMediumHit_Click);
            // 
            // buttonLightHit
            // 
            this.buttonLightHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLightHit.Location = new System.Drawing.Point(820, 316);
            this.buttonLightHit.Name = "buttonLightHit";
            this.buttonLightHit.Size = new System.Drawing.Size(75, 23);
            this.buttonLightHit.TabIndex = 12;
            this.buttonLightHit.Text = "Słaby atak";
            this.buttonLightHit.UseVisualStyleBackColor = true;
            this.buttonLightHit.Visible = false;
            this.buttonLightHit.Click += new System.EventHandler(this.buttonLightHit_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnd.Location = new System.Drawing.Point(488, 245);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(271, 45);
            this.buttonEnd.TabIndex = 13;
            this.buttonEnd.Text = "Wyjdź z pojedynku";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Visible = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // pictureBoxArenaBackground
            // 
            this.pictureBoxArenaBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxArenaBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArenaBackground.Image")));
            this.pictureBoxArenaBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxArenaBackground.Name = "pictureBoxArenaBackground";
            this.pictureBoxArenaBackground.Size = new System.Drawing.Size(1202, 610);
            this.pictureBoxArenaBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArenaBackground.TabIndex = 14;
            this.pictureBoxArenaBackground.TabStop = false;
            // 
            // pictureBoxChampion
            // 
            this.pictureBoxChampion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChampion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChampion.Image")));
            this.pictureBoxChampion.Location = new System.Drawing.Point(628, 9);
            this.pictureBoxChampion.Name = "pictureBoxChampion";
            this.pictureBoxChampion.Size = new System.Drawing.Size(574, 586);
            this.pictureBoxChampion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxChampion.TabIndex = 15;
            this.pictureBoxChampion.TabStop = false;
            // 
            // textBoxChampionName
            // 
            this.textBoxChampionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChampionName.Location = new System.Drawing.Point(970, 6);
            this.textBoxChampionName.Name = "textBoxChampionName";
            this.textBoxChampionName.Size = new System.Drawing.Size(220, 31);
            this.textBoxChampionName.TabIndex = 16;
            this.textBoxChampionName.Text = "Życie bohatera";
            this.textBoxChampionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMonsterName
            // 
            this.textBoxMonsterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMonsterName.Location = new System.Drawing.Point(12, 9);
            this.textBoxMonsterName.Name = "textBoxMonsterName";
            this.textBoxMonsterName.Size = new System.Drawing.Size(220, 31);
            this.textBoxMonsterName.TabIndex = 17;
            this.textBoxMonsterName.Text = "Życie przeciwnika";
            this.textBoxMonsterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 610);
            this.Controls.Add(this.textBoxMonsterName);
            this.Controls.Add(this.textBoxChampionName);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonLightHit);
            this.Controls.Add(this.buttonMediumHit);
            this.Controls.Add(this.buttonStrongHit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxYourLife);
            this.Controls.Add(this.textBoxEnemyLife);
            this.Controls.Add(this.buttonEnemyLvl3);
            this.Controls.Add(this.buttonEnemyLvl2);
            this.Controls.Add(this.buttonEnemyLvl1);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.pictureBoxChampion);
            this.Controls.Add(this.pictureBoxArenaBackground);
            this.Name = "Arena";
            this.Text = "Arena";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArenaBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.Button buttonEnemyLvl1;
        private System.Windows.Forms.Button buttonEnemyLvl2;
        private System.Windows.Forms.Button buttonEnemyLvl3;
        private System.Windows.Forms.TextBox textBoxEnemyLife;
        private System.Windows.Forms.TextBox textBoxYourLife;
        private System.Windows.Forms.Timer timerFightTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStrongHit;
        private System.Windows.Forms.Button buttonMediumHit;
        private System.Windows.Forms.Button buttonLightHit;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.PictureBox pictureBoxArenaBackground;
        private System.Windows.Forms.PictureBox pictureBoxChampion;
        private System.Windows.Forms.TextBox textBoxChampionName;
        private System.Windows.Forms.TextBox textBoxMonsterName;
    }
}