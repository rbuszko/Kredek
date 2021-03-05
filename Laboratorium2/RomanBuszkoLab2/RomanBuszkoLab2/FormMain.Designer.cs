
namespace RomanBuszkoLab2
{
    partial class FormMain
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPadding = new System.Windows.Forms.TextBox();
            this.buttonDrive = new System.Windows.Forms.Button();
            this.buttonFuelUp = new System.Windows.Forms.Button();
            this.buttonMilitary = new System.Windows.Forms.Button();
            this.buttonFly = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 20);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nowy obiekt";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Nazwa";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(12, 67);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 2;
            this.textBoxSpeed.Text = "180";
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(12, 93);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuel.TabIndex = 3;
            this.textBoxFuel.Text = "30";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(12, 119);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 4;
            this.textBoxColor.Text = "Kolor";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(12, 145);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 5;
            this.textBoxYear.Text = "Rok";
            // 
            // textBoxPadding
            // 
            this.textBoxPadding.Location = new System.Drawing.Point(12, 171);
            this.textBoxPadding.Name = "textBoxPadding";
            this.textBoxPadding.Size = new System.Drawing.Size(100, 20);
            this.textBoxPadding.TabIndex = 6;
            this.textBoxPadding.Text = "Tapicerka";
            // 
            // buttonDrive
            // 
            this.buttonDrive.Location = new System.Drawing.Point(12, 197);
            this.buttonDrive.Name = "buttonDrive";
            this.buttonDrive.Size = new System.Drawing.Size(100, 20);
            this.buttonDrive.TabIndex = 7;
            this.buttonDrive.Text = "Jedź";
            this.buttonDrive.UseVisualStyleBackColor = true;
            this.buttonDrive.Click += new System.EventHandler(this.buttonDrive_Click);
            // 
            // buttonFuelUp
            // 
            this.buttonFuelUp.Location = new System.Drawing.Point(12, 223);
            this.buttonFuelUp.Name = "buttonFuelUp";
            this.buttonFuelUp.Size = new System.Drawing.Size(100, 20);
            this.buttonFuelUp.TabIndex = 8;
            this.buttonFuelUp.Text = "Zatankuj";
            this.buttonFuelUp.UseVisualStyleBackColor = true;
            this.buttonFuelUp.Click += new System.EventHandler(this.buttonFuelUp_Click);
            // 
            // buttonMilitary
            // 
            this.buttonMilitary.Location = new System.Drawing.Point(12, 249);
            this.buttonMilitary.Name = "buttonMilitary";
            this.buttonMilitary.Size = new System.Drawing.Size(100, 20);
            this.buttonMilitary.TabIndex = 9;
            this.buttonMilitary.Text = "Wojskowy";
            this.buttonMilitary.UseVisualStyleBackColor = true;
            this.buttonMilitary.Click += new System.EventHandler(this.buttonMilitary_Click);
            // 
            // buttonFly
            // 
            this.buttonFly.Location = new System.Drawing.Point(12, 275);
            this.buttonFly.Name = "buttonFly";
            this.buttonFly.Size = new System.Drawing.Size(100, 20);
            this.buttonFly.TabIndex = 10;
            this.buttonFly.Text = "Latający";
            this.buttonFly.UseVisualStyleBackColor = true;
            this.buttonFly.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(130, 12);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(100, 20);
            this.buttonList.TabIndex = 11;
            this.buttonList.Text = "Nowa lista";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(236, 12);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.Size = new System.Drawing.Size(552, 150);
            this.dataGridViewVehicles.TabIndex = 12;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 301);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(100, 20);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "Znajdź";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonFly);
            this.Controls.Add(this.buttonMilitary);
            this.Controls.Add(this.buttonFuelUp);
            this.Controls.Add(this.buttonDrive);
            this.Controls.Add(this.textBoxPadding);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxFuel);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonNew);
            this.Name = "FormMain";
            this.Text = "Laboratorium2Obiektowość";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPadding;
        private System.Windows.Forms.Button buttonDrive;
        private System.Windows.Forms.Button buttonFuelUp;
        private System.Windows.Forms.Button buttonMilitary;
        private System.Windows.Forms.Button buttonFly;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.Button buttonFind;
    }
}

