
namespace ZadanieDomowe
{
    partial class Walka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Walka));
            this.textBoxPokemonLife = new System.Windows.Forms.TextBox();
            this.textBoxMonsterLife = new System.Windows.Forms.TextBox();
            this.labelPokemonLife = new System.Windows.Forms.Label();
            this.labelMonsterLife = new System.Windows.Forms.Label();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.groupBoxAttack = new System.Windows.Forms.GroupBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.groupBoxPokemon = new System.Windows.Forms.GroupBox();
            this.groupBoxMonster = new System.Windows.Forms.GroupBox();
            this.timerWalki = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBackGroundBeforeEvolution = new System.Windows.Forms.PictureBox();
            this.groupBoxAction.SuspendLayout();
            this.groupBoxAttack.SuspendLayout();
            this.groupBoxPokemon.SuspendLayout();
            this.groupBoxMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGroundBeforeEvolution)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPokemonLife
            // 
            this.textBoxPokemonLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPokemonLife.Location = new System.Drawing.Point(0, 71);
            this.textBoxPokemonLife.Name = "textBoxPokemonLife";
            this.textBoxPokemonLife.Size = new System.Drawing.Size(247, 20);
            this.textBoxPokemonLife.TabIndex = 2;
            this.textBoxPokemonLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMonsterLife
            // 
            this.textBoxMonsterLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMonsterLife.Location = new System.Drawing.Point(0, 71);
            this.textBoxMonsterLife.Name = "textBoxMonsterLife";
            this.textBoxMonsterLife.Size = new System.Drawing.Size(247, 20);
            this.textBoxMonsterLife.TabIndex = 3;
            this.textBoxMonsterLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPokemonLife
            // 
            this.labelPokemonLife.AutoSize = true;
            this.labelPokemonLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPokemonLife.Location = new System.Drawing.Point(29, 32);
            this.labelPokemonLife.Name = "labelPokemonLife";
            this.labelPokemonLife.Size = new System.Drawing.Size(168, 31);
            this.labelPokemonLife.TabIndex = 5;
            this.labelPokemonLife.Text = "Twoje życie";
            // 
            // labelMonsterLife
            // 
            this.labelMonsterLife.AutoSize = true;
            this.labelMonsterLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonsterLife.Location = new System.Drawing.Point(0, 32);
            this.labelMonsterLife.Name = "labelMonsterLife";
            this.labelMonsterLife.Size = new System.Drawing.Size(247, 31);
            this.labelMonsterLife.TabIndex = 6;
            this.labelMonsterLife.Text = "Życie przeciwnika";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.groupBoxAttack);
            this.groupBoxAction.Controls.Add(this.groupBoxPokemon);
            this.groupBoxAction.Controls.Add(this.groupBoxMonster);
            this.groupBoxAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAction.Location = new System.Drawing.Point(0, 307);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(800, 143);
            this.groupBoxAction.TabIndex = 7;
            this.groupBoxAction.TabStop = false;
            // 
            // groupBoxAttack
            // 
            this.groupBoxAttack.Controls.Add(this.buttonAttack);
            this.groupBoxAttack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAttack.Location = new System.Drawing.Point(250, 16);
            this.groupBoxAttack.Name = "groupBoxAttack";
            this.groupBoxAttack.Size = new System.Drawing.Size(300, 124);
            this.groupBoxAttack.TabIndex = 9;
            this.groupBoxAttack.TabStop = false;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAttack.Location = new System.Drawing.Point(3, 16);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(294, 105);
            this.buttonAttack.TabIndex = 0;
            this.buttonAttack.Text = "Atakuj!";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // groupBoxPokemon
            // 
            this.groupBoxPokemon.Controls.Add(this.labelPokemonLife);
            this.groupBoxPokemon.Controls.Add(this.textBoxPokemonLife);
            this.groupBoxPokemon.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPokemon.Location = new System.Drawing.Point(3, 16);
            this.groupBoxPokemon.MaximumSize = new System.Drawing.Size(0, 128);
            this.groupBoxPokemon.MinimumSize = new System.Drawing.Size(247, 128);
            this.groupBoxPokemon.Name = "groupBoxPokemon";
            this.groupBoxPokemon.Size = new System.Drawing.Size(247, 128);
            this.groupBoxPokemon.TabIndex = 8;
            this.groupBoxPokemon.TabStop = false;
            // 
            // groupBoxMonster
            // 
            this.groupBoxMonster.Controls.Add(this.textBoxMonsterLife);
            this.groupBoxMonster.Controls.Add(this.labelMonsterLife);
            this.groupBoxMonster.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxMonster.Location = new System.Drawing.Point(550, 16);
            this.groupBoxMonster.Name = "groupBoxMonster";
            this.groupBoxMonster.Size = new System.Drawing.Size(247, 124);
            this.groupBoxMonster.TabIndex = 7;
            this.groupBoxMonster.TabStop = false;
            // 
            // timerWalki
            // 
            this.timerWalki.Enabled = true;
            this.timerWalki.Interval = 1000;
            this.timerWalki.Tick += new System.EventHandler(this.timerWalki_Tick);
            // 
            // pictureBoxBackGroundBeforeEvolution
            // 
            this.pictureBoxBackGroundBeforeEvolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackGroundBeforeEvolution.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGroundBeforeEvolution.Image")));
            this.pictureBoxBackGroundBeforeEvolution.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGroundBeforeEvolution.Name = "pictureBoxBackGroundBeforeEvolution";
            this.pictureBoxBackGroundBeforeEvolution.Size = new System.Drawing.Size(800, 307);
            this.pictureBoxBackGroundBeforeEvolution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGroundBeforeEvolution.TabIndex = 11;
            this.pictureBoxBackGroundBeforeEvolution.TabStop = false;
            // 
            // Walka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxBackGroundBeforeEvolution);
            this.Controls.Add(this.groupBoxAction);
            this.Name = "Walka";
            this.Text = "Walka";
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAttack.ResumeLayout(false);
            this.groupBoxPokemon.ResumeLayout(false);
            this.groupBoxPokemon.PerformLayout();
            this.groupBoxMonster.ResumeLayout(false);
            this.groupBoxMonster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGroundBeforeEvolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPokemonLife;
        private System.Windows.Forms.TextBox textBoxMonsterLife;
        private System.Windows.Forms.Label labelPokemonLife;
        private System.Windows.Forms.Label labelMonsterLife;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.GroupBox groupBoxPokemon;
        private System.Windows.Forms.GroupBox groupBoxMonster;
        private System.Windows.Forms.GroupBox groupBoxAttack;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Timer timerWalki;
        private System.Windows.Forms.PictureBox pictureBoxBackGroundBeforeEvolution;
    }
}