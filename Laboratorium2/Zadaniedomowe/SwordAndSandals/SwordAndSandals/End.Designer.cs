
namespace SwordAndSandals
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.timerEnd = new System.Windows.Forms.Timer(this.components);
            this.buttonFight = new System.Windows.Forms.Button();
            this.labelBossName = new System.Windows.Forms.Label();
            this.textBoxChampionLife = new System.Windows.Forms.TextBox();
            this.textBoxBossLife = new System.Windows.Forms.TextBox();
            this.buttonDealDmg = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.pictureBoxBossBackground = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoss = new System.Windows.Forms.PictureBox();
            this.textBoxChampionName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // timerEnd
            // 
            this.timerEnd.Interval = 300;
            this.timerEnd.Tick += new System.EventHandler(this.timerEnd_Tick);
            // 
            // buttonFight
            // 
            this.buttonFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFight.Location = new System.Drawing.Point(399, 227);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(104, 41);
            this.buttonFight.TabIndex = 0;
            this.buttonFight.Text = "Walcz!";
            this.buttonFight.UseVisualStyleBackColor = true;
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
            // 
            // labelBossName
            // 
            this.labelBossName.AutoSize = true;
            this.labelBossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBossName.Location = new System.Drawing.Point(406, 9);
            this.labelBossName.Name = "labelBossName";
            this.labelBossName.Size = new System.Drawing.Size(81, 25);
            this.labelBossName.TabIndex = 2;
            this.labelBossName.Text = "Ripper";
            // 
            // textBoxChampionLife
            // 
            this.textBoxChampionLife.Location = new System.Drawing.Point(350, 517);
            this.textBoxChampionLife.Name = "textBoxChampionLife";
            this.textBoxChampionLife.Size = new System.Drawing.Size(201, 20);
            this.textBoxChampionLife.TabIndex = 3;
            // 
            // textBoxBossLife
            // 
            this.textBoxBossLife.Location = new System.Drawing.Point(350, 37);
            this.textBoxBossLife.Name = "textBoxBossLife";
            this.textBoxBossLife.Size = new System.Drawing.Size(201, 20);
            this.textBoxBossLife.TabIndex = 4;
            // 
            // buttonDealDmg
            // 
            this.buttonDealDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDealDmg.Location = new System.Drawing.Point(393, 227);
            this.buttonDealDmg.Name = "buttonDealDmg";
            this.buttonDealDmg.Size = new System.Drawing.Size(129, 44);
            this.buttonDealDmg.TabIndex = 5;
            this.buttonDealDmg.Text = "Uderzaj!";
            this.buttonDealDmg.UseVisualStyleBackColor = true;
            this.buttonDealDmg.Visible = false;
            this.buttonDealDmg.Click += new System.EventHandler(this.buttonDealDmg_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnd.Location = new System.Drawing.Point(399, 227);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(111, 44);
            this.buttonEnd.TabIndex = 6;
            this.buttonEnd.Text = "Zakończ";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Visible = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // pictureBoxBossBackground
            // 
            this.pictureBoxBossBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBossBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBossBackground.Image")));
            this.pictureBoxBossBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBossBackground.Name = "pictureBoxBossBackground";
            this.pictureBoxBossBackground.Size = new System.Drawing.Size(892, 549);
            this.pictureBoxBossBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBossBackground.TabIndex = 7;
            this.pictureBoxBossBackground.TabStop = false;
            // 
            // pictureBoxBoss
            // 
            this.pictureBoxBoss.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBoss.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBoss.Image")));
            this.pictureBoxBoss.Location = new System.Drawing.Point(256, 52);
            this.pictureBoxBoss.Name = "pictureBoxBoss";
            this.pictureBoxBoss.Size = new System.Drawing.Size(395, 445);
            this.pictureBoxBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBoss.TabIndex = 8;
            this.pictureBoxBoss.TabStop = false;
            // 
            // textBoxChampionName
            // 
            this.textBoxChampionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChampionName.Location = new System.Drawing.Point(350, 480);
            this.textBoxChampionName.Name = "textBoxChampionName";
            this.textBoxChampionName.Size = new System.Drawing.Size(201, 31);
            this.textBoxChampionName.TabIndex = 9;
            this.textBoxChampionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 549);
            this.Controls.Add(this.textBoxChampionName);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonDealDmg);
            this.Controls.Add(this.textBoxBossLife);
            this.Controls.Add(this.textBoxChampionLife);
            this.Controls.Add(this.labelBossName);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.pictureBoxBoss);
            this.Controls.Add(this.pictureBoxBossBackground);
            this.Name = "End";
            this.Text = "End";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerEnd;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Label labelBossName;
        private System.Windows.Forms.TextBox textBoxChampionLife;
        private System.Windows.Forms.TextBox textBoxBossLife;
        private System.Windows.Forms.Button buttonDealDmg;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.PictureBox pictureBoxBossBackground;
        private System.Windows.Forms.PictureBox pictureBoxBoss;
        private System.Windows.Forms.TextBox textBoxChampionName;
    }
}