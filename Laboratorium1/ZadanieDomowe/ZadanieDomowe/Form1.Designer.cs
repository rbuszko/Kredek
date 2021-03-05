
namespace ZadanieDomowe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxOpening = new System.Windows.Forms.PictureBox();
            this.labelLoading = new System.Windows.Forms.Label();
            this.timerŁadowanie = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpening)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOpening
            // 
            this.pictureBoxOpening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOpening.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpening.Image")));
            this.pictureBoxOpening.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOpening.Name = "pictureBoxOpening";
            this.pictureBoxOpening.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxOpening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpening.TabIndex = 0;
            this.pictureBoxOpening.TabStop = false;
            // 
            // labelLoading
            // 
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoading.Font = new System.Drawing.Font("Sitka Display", 68.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoading.Location = new System.Drawing.Point(0, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(800, 450);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "Ładowanie";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerŁadowanie
            // 
            this.timerŁadowanie.Enabled = true;
            this.timerŁadowanie.Interval = 4000;
            this.timerŁadowanie.Tick += new System.EventHandler(this.timerŁadowanie_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.pictureBoxOpening);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpening)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOpening;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Timer timerŁadowanie;
    }
}

