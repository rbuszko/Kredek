
namespace ZadanieDomowe
{
    partial class OknoGry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGry));
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxLife = new System.Windows.Forms.GroupBox();
            this.labelLife = new System.Windows.Forms.Label();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.textBoxLife = new System.Windows.Forms.TextBox();
            this.groupBoxEnergy = new System.Windows.Forms.GroupBox();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.textBoxEnergy = new System.Windows.Forms.TextBox();
            this.groupBoxAttack = new System.Windows.Forms.GroupBox();
            this.textBoxAttack = new System.Windows.Forms.TextBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.groupDefence = new System.Windows.Forms.GroupBox();
            this.textBoxDefence = new System.Windows.Forms.TextBox();
            this.labelDefence = new System.Windows.Forms.Label();
            this.groupBoxHunger = new System.Windows.Forms.GroupBox();
            this.textBoxHunger = new System.Windows.Forms.TextBox();
            this.labelHunger = new System.Windows.Forms.Label();
            this.pictureBoxPokemonBeforeEvolution = new System.Windows.Forms.PictureBox();
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonDefence = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonFight = new System.Windows.Forms.Button();
            this.pictureBoxPokemonAfterEvolution = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxLife.SuspendLayout();
            this.groupBoxEnergy.SuspendLayout();
            this.groupBoxAttack.SuspendLayout();
            this.groupDefence.SuspendLayout();
            this.groupBoxHunger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemonBeforeEvolution)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemonAfterEvolution)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGround.Image")));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(1248, 561);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 0;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxStatus.Controls.Add(this.groupBoxLife);
            this.groupBoxStatus.Controls.Add(this.groupBoxEnergy);
            this.groupBoxStatus.Controls.Add(this.groupBoxAttack);
            this.groupBoxStatus.Controls.Add(this.groupDefence);
            this.groupBoxStatus.Controls.Add(this.groupBoxHunger);
            this.groupBoxStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(214, 561);
            this.groupBoxStatus.TabIndex = 1;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxLife
            // 
            this.groupBoxLife.Controls.Add(this.labelLife);
            this.groupBoxLife.Controls.Add(this.textBoxLife);
            this.groupBoxLife.Location = new System.Drawing.Point(6, 31);
            this.groupBoxLife.Name = "groupBoxLife";
            this.groupBoxLife.Size = new System.Drawing.Size(200, 100);
            this.groupBoxLife.TabIndex = 14;
            this.groupBoxLife.TabStop = false;
            // 
            // labelLife
            // 
            this.labelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLife.Location = new System.Drawing.Point(5, 16);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(189, 47);
            this.labelLife.TabIndex = 0;
            this.labelLife.Text = "Życie";
            this.labelLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxExperience.Location = new System.Drawing.Point(220, 58);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(284, 31);
            this.textBoxExperience.TabIndex = 7;
            this.textBoxExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLife
            // 
            this.textBoxLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLife.Location = new System.Drawing.Point(5, 71);
            this.textBoxLife.Name = "textBoxLife";
            this.textBoxLife.Size = new System.Drawing.Size(189, 20);
            this.textBoxLife.TabIndex = 1;
            this.textBoxLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxEnergy
            // 
            this.groupBoxEnergy.Controls.Add(this.labelEnergy);
            this.groupBoxEnergy.Controls.Add(this.textBoxEnergy);
            this.groupBoxEnergy.Location = new System.Drawing.Point(6, 137);
            this.groupBoxEnergy.Name = "groupBoxEnergy";
            this.groupBoxEnergy.Size = new System.Drawing.Size(200, 100);
            this.groupBoxEnergy.TabIndex = 13;
            this.groupBoxEnergy.TabStop = false;
            // 
            // labelEnergy
            // 
            this.labelEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnergy.Location = new System.Drawing.Point(6, 16);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(189, 47);
            this.labelEnergy.TabIndex = 2;
            this.labelEnergy.Text = "Energia";
            this.labelEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEnergy
            // 
            this.textBoxEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEnergy.Location = new System.Drawing.Point(6, 74);
            this.textBoxEnergy.Name = "textBoxEnergy";
            this.textBoxEnergy.Size = new System.Drawing.Size(189, 20);
            this.textBoxEnergy.TabIndex = 3;
            this.textBoxEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxAttack
            // 
            this.groupBoxAttack.Controls.Add(this.textBoxAttack);
            this.groupBoxAttack.Controls.Add(this.labelAttack);
            this.groupBoxAttack.Location = new System.Drawing.Point(6, 243);
            this.groupBoxAttack.Name = "groupBoxAttack";
            this.groupBoxAttack.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAttack.TabIndex = 12;
            this.groupBoxAttack.TabStop = false;
            // 
            // textBoxAttack
            // 
            this.textBoxAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAttack.Location = new System.Drawing.Point(5, 74);
            this.textBoxAttack.Name = "textBoxAttack";
            this.textBoxAttack.Size = new System.Drawing.Size(189, 20);
            this.textBoxAttack.TabIndex = 7;
            this.textBoxAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExperience.Location = new System.Drawing.Point(220, 9);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(284, 42);
            this.labelExperience.TabIndex = 8;
            this.labelExperience.Text = "Doświadczenie";
            // 
            // labelAttack
            // 
            this.labelAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAttack.Location = new System.Drawing.Point(5, 16);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(189, 47);
            this.labelAttack.TabIndex = 4;
            this.labelAttack.Text = "Atak";
            this.labelAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDefence
            // 
            this.groupDefence.Controls.Add(this.textBoxDefence);
            this.groupDefence.Controls.Add(this.labelDefence);
            this.groupDefence.Location = new System.Drawing.Point(6, 349);
            this.groupDefence.Name = "groupDefence";
            this.groupDefence.Size = new System.Drawing.Size(200, 100);
            this.groupDefence.TabIndex = 11;
            this.groupDefence.TabStop = false;
            // 
            // textBoxDefence
            // 
            this.textBoxDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDefence.Location = new System.Drawing.Point(5, 74);
            this.textBoxDefence.Name = "textBoxDefence";
            this.textBoxDefence.Size = new System.Drawing.Size(189, 20);
            this.textBoxDefence.TabIndex = 8;
            this.textBoxDefence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDefence
            // 
            this.labelDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDefence.Location = new System.Drawing.Point(5, 16);
            this.labelDefence.Name = "labelDefence";
            this.labelDefence.Size = new System.Drawing.Size(189, 47);
            this.labelDefence.TabIndex = 5;
            this.labelDefence.Text = "Obrona";
            this.labelDefence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxHunger
            // 
            this.groupBoxHunger.Controls.Add(this.textBoxHunger);
            this.groupBoxHunger.Controls.Add(this.labelHunger);
            this.groupBoxHunger.Location = new System.Drawing.Point(6, 455);
            this.groupBoxHunger.Name = "groupBoxHunger";
            this.groupBoxHunger.Size = new System.Drawing.Size(200, 100);
            this.groupBoxHunger.TabIndex = 10;
            this.groupBoxHunger.TabStop = false;
            // 
            // textBoxHunger
            // 
            this.textBoxHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHunger.Location = new System.Drawing.Point(6, 74);
            this.textBoxHunger.Name = "textBoxHunger";
            this.textBoxHunger.Size = new System.Drawing.Size(189, 20);
            this.textBoxHunger.TabIndex = 9;
            this.textBoxHunger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHunger
            // 
            this.labelHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHunger.Location = new System.Drawing.Point(6, 16);
            this.labelHunger.Name = "labelHunger";
            this.labelHunger.Size = new System.Drawing.Size(189, 47);
            this.labelHunger.TabIndex = 6;
            this.labelHunger.Text = "Głód";
            this.labelHunger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPokemonBeforeEvolution
            // 
            this.pictureBoxPokemonBeforeEvolution.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPokemonBeforeEvolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPokemonBeforeEvolution.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPokemonBeforeEvolution.Image")));
            this.pictureBoxPokemonBeforeEvolution.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPokemonBeforeEvolution.Name = "pictureBoxPokemonBeforeEvolution";
            this.pictureBoxPokemonBeforeEvolution.Size = new System.Drawing.Size(1248, 561);
            this.pictureBoxPokemonBeforeEvolution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPokemonBeforeEvolution.TabIndex = 2;
            this.pictureBoxPokemonBeforeEvolution.TabStop = false;
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Enabled = true;
            this.timerCzasGry.Interval = 1000;
            this.timerCzasGry.Tick += new System.EventHandler(this.timerCzasGry_Tick);
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAttack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAttack.Location = new System.Drawing.Point(525, 18);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(261, 79);
            this.buttonAttack.TabIndex = 3;
            this.buttonAttack.Text = "Trenuj siłę";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonDefence
            // 
            this.buttonDefence.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDefence.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDefence.Location = new System.Drawing.Point(3, 18);
            this.buttonDefence.MaximumSize = new System.Drawing.Size(261, 79);
            this.buttonDefence.MinimumSize = new System.Drawing.Size(261, 79);
            this.buttonDefence.Name = "buttonDefence";
            this.buttonDefence.Size = new System.Drawing.Size(261, 79);
            this.buttonDefence.TabIndex = 4;
            this.buttonDefence.Text = "Trenuj obronę";
            this.buttonDefence.UseVisualStyleBackColor = false;
            this.buttonDefence.Click += new System.EventHandler(this.buttonDefence_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFeed.Location = new System.Drawing.Point(264, 18);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(261, 79);
            this.buttonFeed.TabIndex = 5;
            this.buttonFeed.Text = "Nakarm";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxAction.Controls.Add(this.buttonFight);
            this.groupBoxAction.Controls.Add(this.buttonAttack);
            this.groupBoxAction.Controls.Add(this.buttonFeed);
            this.groupBoxAction.Controls.Add(this.buttonDefence);
            this.groupBoxAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAction.Location = new System.Drawing.Point(214, 461);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(1034, 100);
            this.groupBoxAction.TabIndex = 6;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Akcja";
            // 
            // buttonFight
            // 
            this.buttonFight.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFight.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFight.Location = new System.Drawing.Point(786, 18);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(242, 79);
            this.buttonFight.TabIndex = 7;
            this.buttonFight.Text = "Walcz";
            this.buttonFight.UseVisualStyleBackColor = false;
            this.buttonFight.Click += new System.EventHandler(this.buttonWalcz_Click);
            // 
            // pictureBoxPokemonAfterEvolution
            // 
            this.pictureBoxPokemonAfterEvolution.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPokemonAfterEvolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPokemonAfterEvolution.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPokemonAfterEvolution.Image")));
            this.pictureBoxPokemonAfterEvolution.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPokemonAfterEvolution.Name = "pictureBoxPokemonAfterEvolution";
            this.pictureBoxPokemonAfterEvolution.Size = new System.Drawing.Size(1248, 561);
            this.pictureBoxPokemonAfterEvolution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPokemonAfterEvolution.TabIndex = 7;
            this.pictureBoxPokemonAfterEvolution.TabStop = false;
            // 
            // OknoGry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 561);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.pictureBoxPokemonAfterEvolution);
            this.Controls.Add(this.pictureBoxPokemonBeforeEvolution);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Name = "OknoGry";
            this.Text = "OknoGry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxLife.ResumeLayout(false);
            this.groupBoxLife.PerformLayout();
            this.groupBoxEnergy.ResumeLayout(false);
            this.groupBoxEnergy.PerformLayout();
            this.groupBoxAttack.ResumeLayout(false);
            this.groupBoxAttack.PerformLayout();
            this.groupDefence.ResumeLayout(false);
            this.groupDefence.PerformLayout();
            this.groupBoxHunger.ResumeLayout(false);
            this.groupBoxHunger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemonBeforeEvolution)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemonAfterEvolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.TextBox textBoxHunger;
        private System.Windows.Forms.TextBox textBoxDefence;
        private System.Windows.Forms.TextBox textBoxAttack;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelDefence;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.TextBox textBoxEnergy;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.TextBox textBoxLife;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.PictureBox pictureBoxPokemonBeforeEvolution;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonDefence;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.GroupBox groupBoxLife;
        private System.Windows.Forms.GroupBox groupBoxEnergy;
        private System.Windows.Forms.GroupBox groupBoxAttack;
        private System.Windows.Forms.GroupBox groupDefence;
        private System.Windows.Forms.GroupBox groupBoxHunger;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.PictureBox pictureBoxPokemonAfterEvolution;
    }
}