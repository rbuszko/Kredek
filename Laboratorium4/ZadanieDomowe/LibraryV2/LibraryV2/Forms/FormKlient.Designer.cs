
namespace LibraryV2.Forms
{
    partial class FormKlient
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
            this.dataGridViewBooksToLend = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersonBooks = new System.Windows.Forms.DataGridView();
            this.labelBooksToRent = new System.Windows.Forms.Label();
            this.labelPersonBooks = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonLend = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksToLend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooksToLend
            // 
            this.dataGridViewBooksToLend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksToLend.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewBooksToLend.Name = "dataGridViewBooksToLend";
            this.dataGridViewBooksToLend.Size = new System.Drawing.Size(847, 150);
            this.dataGridViewBooksToLend.TabIndex = 0;
            // 
            // dataGridViewPersonBooks
            // 
            this.dataGridViewPersonBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonBooks.Location = new System.Drawing.Point(12, 214);
            this.dataGridViewPersonBooks.Name = "dataGridViewPersonBooks";
            this.dataGridViewPersonBooks.Size = new System.Drawing.Size(847, 150);
            this.dataGridViewPersonBooks.TabIndex = 1;
            // 
            // labelBooksToRent
            // 
            this.labelBooksToRent.AutoSize = true;
            this.labelBooksToRent.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBooksToRent.Location = new System.Drawing.Point(8, 9);
            this.labelBooksToRent.Name = "labelBooksToRent";
            this.labelBooksToRent.Size = new System.Drawing.Size(260, 23);
            this.labelBooksToRent.TabIndex = 2;
            this.labelBooksToRent.Text = "Książki do wypożyczenia:";
            // 
            // labelPersonBooks
            // 
            this.labelPersonBooks.AutoSize = true;
            this.labelPersonBooks.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPersonBooks.Location = new System.Drawing.Point(8, 188);
            this.labelPersonBooks.Name = "labelPersonBooks";
            this.labelPersonBooks.Size = new System.Drawing.Size(150, 23);
            this.labelPersonBooks.TabIndex = 3;
            this.labelPersonBooks.Text = "Twoje książki:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(8, 381);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(38, 23);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxId.Location = new System.Drawing.Point(58, 378);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 29);
            this.textBoxId.TabIndex = 5;
            // 
            // buttonLend
            // 
            this.buttonLend.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLend.Location = new System.Drawing.Point(184, 370);
            this.buttonLend.Name = "buttonLend";
            this.buttonLend.Size = new System.Drawing.Size(129, 47);
            this.buttonLend.TabIndex = 6;
            this.buttonLend.Text = "Wypożycz";
            this.buttonLend.UseVisualStyleBackColor = true;
            this.buttonLend.Click += new System.EventHandler(this.buttonLend_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturn.Location = new System.Drawing.Point(319, 370);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(129, 47);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "Zwróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 424);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonLend);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelPersonBooks);
            this.Controls.Add(this.labelBooksToRent);
            this.Controls.Add(this.dataGridViewPersonBooks);
            this.Controls.Add(this.dataGridViewBooksToLend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormKlient";
            this.Text = "Okno Klienta";
            this.Load += new System.EventHandler(this.FormKlient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksToLend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooksToLend;
        private System.Windows.Forms.DataGridView dataGridViewPersonBooks;
        private System.Windows.Forms.Label labelBooksToRent;
        private System.Windows.Forms.Label labelPersonBooks;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonLend;
        private System.Windows.Forms.Button buttonReturn;
    }
}