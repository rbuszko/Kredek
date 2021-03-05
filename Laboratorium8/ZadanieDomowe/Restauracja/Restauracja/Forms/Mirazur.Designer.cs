
namespace Restauracja
{
    partial class Mirazur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mirazur));
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddMargherita = new System.Windows.Forms.Button();
            this.buttonFirstWaiter = new System.Windows.Forms.Button();
            this.labelMargherita = new System.Windows.Forms.Label();
            this.labelFunghi = new System.Windows.Forms.Label();
            this.labelProsciutto = new System.Windows.Forms.Label();
            this.labelSalame = new System.Windows.Forms.Label();
            this.buttonAddProsciutto = new System.Windows.Forms.Button();
            this.buttonAddFunghi = new System.Windows.Forms.Button();
            this.buttonAddSalame = new System.Windows.Forms.Button();
            this.buttonSecondWaiter = new System.Windows.Forms.Button();
            this.pictureBoxWaiter1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWaiter2 = new System.Windows.Forms.PictureBox();
            this.labelService = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescription,
            this.columnHeaderPrice});
            this.listViewOrders.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(12, 339);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(535, 176);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Opis zamówienia";
            this.columnHeaderDescription.Width = 403;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena";
            this.columnHeaderPrice.Width = 123;
            // 
            // buttonAddMargherita
            // 
            this.buttonAddMargherita.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMargherita.Location = new System.Drawing.Point(199, 56);
            this.buttonAddMargherita.Name = "buttonAddMargherita";
            this.buttonAddMargherita.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMargherita.TabIndex = 1;
            this.buttonAddMargherita.Text = "Zamów";
            this.buttonAddMargherita.UseVisualStyleBackColor = true;
            this.buttonAddMargherita.Click += new System.EventHandler(this.buttonAddMargherita_Click);
            // 
            // buttonFirstWaiter
            // 
            this.buttonFirstWaiter.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFirstWaiter.Location = new System.Drawing.Point(553, 376);
            this.buttonFirstWaiter.Name = "buttonFirstWaiter";
            this.buttonFirstWaiter.Size = new System.Drawing.Size(75, 23);
            this.buttonFirstWaiter.TabIndex = 2;
            this.buttonFirstWaiter.Text = "Obsłuż";
            this.buttonFirstWaiter.UseVisualStyleBackColor = true;
            this.buttonFirstWaiter.Click += new System.EventHandler(this.buttonFirstWaiter_Click);
            // 
            // labelMargherita
            // 
            this.labelMargherita.AutoSize = true;
            this.labelMargherita.BackColor = System.Drawing.Color.Transparent;
            this.labelMargherita.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMargherita.Location = new System.Drawing.Point(98, 56);
            this.labelMargherita.Name = "labelMargherita";
            this.labelMargherita.Size = new System.Drawing.Size(76, 26);
            this.labelMargherita.TabIndex = 3;
            this.labelMargherita.Text = "Margheritta";
            // 
            // labelFunghi
            // 
            this.labelFunghi.AutoSize = true;
            this.labelFunghi.BackColor = System.Drawing.Color.Transparent;
            this.labelFunghi.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunghi.Location = new System.Drawing.Point(98, 111);
            this.labelFunghi.Name = "labelFunghi";
            this.labelFunghi.Size = new System.Drawing.Size(49, 26);
            this.labelFunghi.TabIndex = 4;
            this.labelFunghi.Text = "Funghi";
            // 
            // labelProsciutto
            // 
            this.labelProsciutto.AutoSize = true;
            this.labelProsciutto.BackColor = System.Drawing.Color.Transparent;
            this.labelProsciutto.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProsciutto.Location = new System.Drawing.Point(98, 169);
            this.labelProsciutto.Name = "labelProsciutto";
            this.labelProsciutto.Size = new System.Drawing.Size(66, 26);
            this.labelProsciutto.TabIndex = 5;
            this.labelProsciutto.Text = "Prosciutto";
            // 
            // labelSalame
            // 
            this.labelSalame.AutoSize = true;
            this.labelSalame.BackColor = System.Drawing.Color.Transparent;
            this.labelSalame.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalame.Location = new System.Drawing.Point(98, 224);
            this.labelSalame.Name = "labelSalame";
            this.labelSalame.Size = new System.Drawing.Size(51, 26);
            this.labelSalame.TabIndex = 6;
            this.labelSalame.Text = "Salame";
            // 
            // buttonAddProsciutto
            // 
            this.buttonAddProsciutto.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProsciutto.Location = new System.Drawing.Point(199, 169);
            this.buttonAddProsciutto.Name = "buttonAddProsciutto";
            this.buttonAddProsciutto.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProsciutto.TabIndex = 7;
            this.buttonAddProsciutto.Text = "Zamów";
            this.buttonAddProsciutto.UseVisualStyleBackColor = true;
            this.buttonAddProsciutto.Click += new System.EventHandler(this.buttonAddProsciutto_Click);
            // 
            // buttonAddFunghi
            // 
            this.buttonAddFunghi.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFunghi.Location = new System.Drawing.Point(199, 111);
            this.buttonAddFunghi.Name = "buttonAddFunghi";
            this.buttonAddFunghi.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFunghi.TabIndex = 8;
            this.buttonAddFunghi.Text = "Zamów";
            this.buttonAddFunghi.UseVisualStyleBackColor = true;
            this.buttonAddFunghi.Click += new System.EventHandler(this.buttonAddFunghi_Click);
            // 
            // buttonAddSalame
            // 
            this.buttonAddSalame.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSalame.Location = new System.Drawing.Point(199, 224);
            this.buttonAddSalame.Name = "buttonAddSalame";
            this.buttonAddSalame.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSalame.TabIndex = 9;
            this.buttonAddSalame.Text = "Zamów";
            this.buttonAddSalame.UseVisualStyleBackColor = true;
            this.buttonAddSalame.Click += new System.EventHandler(this.buttonAddSalame_Click);
            // 
            // buttonSecondWaiter
            // 
            this.buttonSecondWaiter.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSecondWaiter.Location = new System.Drawing.Point(758, 339);
            this.buttonSecondWaiter.Name = "buttonSecondWaiter";
            this.buttonSecondWaiter.Size = new System.Drawing.Size(75, 23);
            this.buttonSecondWaiter.TabIndex = 10;
            this.buttonSecondWaiter.Text = "Obsłuż";
            this.buttonSecondWaiter.UseVisualStyleBackColor = true;
            this.buttonSecondWaiter.Click += new System.EventHandler(this.buttonSecondWaiter_Click);
            // 
            // pictureBoxWaiter1
            // 
            this.pictureBoxWaiter1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWaiter1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWaiter1.Image")));
            this.pictureBoxWaiter1.Location = new System.Drawing.Point(477, 128);
            this.pictureBoxWaiter1.Name = "pictureBoxWaiter1";
            this.pictureBoxWaiter1.Size = new System.Drawing.Size(235, 258);
            this.pictureBoxWaiter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWaiter1.TabIndex = 11;
            this.pictureBoxWaiter1.TabStop = false;
            // 
            // pictureBoxWaiter2
            // 
            this.pictureBoxWaiter2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWaiter2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWaiter2.Image")));
            this.pictureBoxWaiter2.Location = new System.Drawing.Point(553, 81);
            this.pictureBoxWaiter2.Name = "pictureBoxWaiter2";
            this.pictureBoxWaiter2.Size = new System.Drawing.Size(446, 305);
            this.pictureBoxWaiter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWaiter2.TabIndex = 12;
            this.pictureBoxWaiter2.TabStop = false;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelService.Location = new System.Drawing.Point(155, 314);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(184, 22);
            this.labelService.TabIndex = 13;
            this.labelService.Text = "Tablica zamówień";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(79, 41);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(211, 221);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 14;
            this.pictureBoxMenu.TabStop = false;
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackGround.Image")));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(868, 527);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 15;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // Mirazur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 527);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.buttonSecondWaiter);
            this.Controls.Add(this.buttonAddSalame);
            this.Controls.Add(this.buttonAddFunghi);
            this.Controls.Add(this.buttonAddProsciutto);
            this.Controls.Add(this.labelSalame);
            this.Controls.Add(this.labelProsciutto);
            this.Controls.Add(this.labelFunghi);
            this.Controls.Add(this.labelMargherita);
            this.Controls.Add(this.buttonFirstWaiter);
            this.Controls.Add(this.buttonAddMargherita);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.pictureBoxWaiter1);
            this.Controls.Add(this.pictureBoxWaiter2);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Name = "Mirazur";
            this.Text = "Mirazur";
            this.Load += new System.EventHandler(this.Mirazur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button buttonAddMargherita;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button buttonFirstWaiter;
        private System.Windows.Forms.Label labelMargherita;
        private System.Windows.Forms.Label labelFunghi;
        private System.Windows.Forms.Label labelProsciutto;
        private System.Windows.Forms.Label labelSalame;
        private System.Windows.Forms.Button buttonAddProsciutto;
        private System.Windows.Forms.Button buttonAddFunghi;
        private System.Windows.Forms.Button buttonAddSalame;
        private System.Windows.Forms.Button buttonSecondWaiter;
        private System.Windows.Forms.PictureBox pictureBoxWaiter1;
        private System.Windows.Forms.PictureBox pictureBoxWaiter2;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBoxBackGround;
    }
}

