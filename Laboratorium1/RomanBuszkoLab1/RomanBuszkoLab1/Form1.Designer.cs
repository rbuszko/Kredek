
namespace RomanBuszkoLab1
{
    partial class Form1
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
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.IntColor = new System.Windows.Forms.Button();
            this.textBoxCount2 = new System.Windows.Forms.TextBox();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor1
            // 
            this.buttonColor1.Location = new System.Drawing.Point(12, 12);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(112, 41);
            this.buttonColor1.TabIndex = 0;
            this.buttonColor1.Text = "Zmień kolor 2 przycisku";
            this.buttonColor1.UseVisualStyleBackColor = true;
            this.buttonColor1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Location = new System.Drawing.Point(12, 71);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(112, 41);
            this.buttonColor2.TabIndex = 1;
            this.buttonColor2.Text = "Zmień kolor 1 przycisku";
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(12, 130);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(112, 20);
            this.textBoxCount.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 41);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // IntColor
            // 
            this.IntColor.Location = new System.Drawing.Point(168, 86);
            this.IntColor.Name = "IntColor";
            this.IntColor.Size = new System.Drawing.Size(112, 41);
            this.IntColor.TabIndex = 4;
            this.IntColor.Text = "Kolorowy";
            this.IntColor.UseVisualStyleBackColor = true;
            // 
            // textBoxCount2
            // 
            this.textBoxCount2.Location = new System.Drawing.Point(12, 225);
            this.textBoxCount2.Name = "textBoxCount2";
            this.textBoxCount2.Size = new System.Drawing.Size(112, 20);
            this.textBoxCount2.TabIndex = 5;
            this.textBoxCount2.TextChanged += new System.EventHandler(this.textBoxCount2_TextChanged);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(168, 167);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(112, 41);
            this.buttonMultiply.TabIndex = 6;
            this.buttonMultiply.Text = "Pomnóż";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick_1);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 262);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 41);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(168, 225);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(112, 41);
            this.New.TabIndex = 8;
            this.New.Text = "Nowe";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.New);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.textBoxCount2);
            this.Controls.Add(this.IntColor);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.buttonColor1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor1;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button IntColor;
        private System.Windows.Forms.TextBox textBoxCount2;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button New;
    }
}

