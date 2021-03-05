
namespace Library.Forms
{
    partial class FormClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dataGridViewBooksToLend = new System.Windows.Forms.DataGridView();
            this.labelBooksToRent = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPersonBooks = new System.Windows.Forms.Label();
            this.dataGridViewPersonBooks = new System.Windows.Forms.DataGridView();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.buttonLend = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksToLend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(785, 326);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // dataGridViewBooksToLend
            // 
            this.dataGridViewBooksToLend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewBooksToLend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooksToLend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooksToLend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksToLend.EnableHeadersVisualStyles = false;
            this.dataGridViewBooksToLend.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewBooksToLend.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewBooksToLend.Name = "dataGridViewBooksToLend";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBooksToLend.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBooksToLend.Size = new System.Drawing.Size(1015, 117);
            this.dataGridViewBooksToLend.TabIndex = 2;
            // 
            // labelBooksToRent
            // 
            this.labelBooksToRent.AutoSize = true;
            this.labelBooksToRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBooksToRent.Location = new System.Drawing.Point(12, 9);
            this.labelBooksToRent.Name = "labelBooksToRent";
            this.labelBooksToRent.Size = new System.Drawing.Size(204, 20);
            this.labelBooksToRent.TabIndex = 33;
            this.labelBooksToRent.Text = "Książki do wypożyczenia";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(154, 350);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 17;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(58, 348);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 20);
            this.labelId.TabIndex = 25;
            this.labelId.Text = "Id:";
            // 
            // labelPersonBooks
            // 
            this.labelPersonBooks.AutoSize = true;
            this.labelPersonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPersonBooks.Location = new System.Drawing.Point(8, 152);
            this.labelPersonBooks.Name = "labelPersonBooks";
            this.labelPersonBooks.Size = new System.Drawing.Size(114, 20);
            this.labelPersonBooks.TabIndex = 34;
            this.labelPersonBooks.Text = "Twoje książki";
            // 
            // dataGridViewPersonBooks
            // 
            this.dataGridViewPersonBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewPersonBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPersonBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonBooks.EnableHeadersVisualStyles = false;
            this.dataGridViewPersonBooks.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewPersonBooks.Location = new System.Drawing.Point(12, 175);
            this.dataGridViewPersonBooks.Name = "dataGridViewPersonBooks";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewPersonBooks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPersonBooks.Size = new System.Drawing.Size(1015, 117);
            this.dataGridViewPersonBooks.TabIndex = 35;
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFisrtName.Location = new System.Drawing.Point(690, 326);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(48, 20);
            this.labelFisrtName.TabIndex = 36;
            this.labelFisrtName.Text = "Imię:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(690, 352);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(89, 20);
            this.labelLastName.TabIndex = 37;
            this.labelLastName.Text = "Nazwisko:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAge.Location = new System.Drawing.Point(690, 379);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(53, 20);
            this.labelAge.TabIndex = 38;
            this.labelAge.Text = "Wiek:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(785, 352);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 39;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(785, 379);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 40;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRole.Location = new System.Drawing.Point(690, 405);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(51, 20);
            this.labelRole.TabIndex = 41;
            this.labelRole.Text = "Rola:";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(785, 405);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxRole.TabIndex = 42;
            // 
            // buttonLend
            // 
            this.buttonLend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLend.Location = new System.Drawing.Point(19, 390);
            this.buttonLend.Name = "buttonLend";
            this.buttonLend.Size = new System.Drawing.Size(109, 35);
            this.buttonLend.TabIndex = 43;
            this.buttonLend.Text = "Wypożycz";
            this.buttonLend.UseVisualStyleBackColor = true;
            this.buttonLend.Click += new System.EventHandler(this.buttonLend_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturn.Location = new System.Drawing.Point(154, 390);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(109, 35);
            this.buttonReturn.TabIndex = 44;
            this.buttonReturn.Text = "Zwróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonLend);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFisrtName);
            this.Controls.Add(this.dataGridViewPersonBooks);
            this.Controls.Add(this.labelPersonBooks);
            this.Controls.Add(this.labelBooksToRent);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridViewBooksToLend);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksToLend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DataGridView dataGridViewBooksToLend;
        private System.Windows.Forms.Label labelBooksToRent;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPersonBooks;
        private System.Windows.Forms.DataGridView dataGridViewPersonBooks;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Button buttonLend;
        private System.Windows.Forms.Button buttonReturn;
    }
}