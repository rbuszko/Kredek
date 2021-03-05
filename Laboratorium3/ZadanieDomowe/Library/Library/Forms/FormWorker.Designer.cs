
namespace Library.Forms
{
    partial class FormWorker
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAuthorFirstName = new System.Windows.Forms.Label();
            this.labelAuthorLastName = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelRestriction = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxRestriction = new System.Windows.Forms.TextBox();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.EnableHeadersVisualStyles = false;
            this.dataGridViewBooks.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBooks.Size = new System.Drawing.Size(766, 255);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(8, 273);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 20);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(8, 324);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(53, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Tytuł:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGenre.Location = new System.Drawing.Point(8, 350);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(83, 20);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Gatunek:";
            // 
            // labelAuthorFirstName
            // 
            this.labelAuthorFirstName.AutoSize = true;
            this.labelAuthorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthorFirstName.Location = new System.Drawing.Point(8, 375);
            this.labelAuthorFirstName.Name = "labelAuthorFirstName";
            this.labelAuthorFirstName.Size = new System.Drawing.Size(105, 20);
            this.labelAuthorFirstName.TabIndex = 4;
            this.labelAuthorFirstName.Text = "Imię autora:";
            // 
            // labelAuthorLastName
            // 
            this.labelAuthorLastName.AutoSize = true;
            this.labelAuthorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthorLastName.Location = new System.Drawing.Point(8, 401);
            this.labelAuthorLastName.Name = "labelAuthorLastName";
            this.labelAuthorLastName.Size = new System.Drawing.Size(146, 20);
            this.labelAuthorLastName.TabIndex = 5;
            this.labelAuthorLastName.Text = "Nazwisko autora:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelState.Location = new System.Drawing.Point(8, 427);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(52, 20);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "Stan:";
            // 
            // labelRestriction
            // 
            this.labelRestriction.AutoSize = true;
            this.labelRestriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRestriction.Location = new System.Drawing.Point(8, 453);
            this.labelRestriction.Name = "labelRestriction";
            this.labelRestriction.Size = new System.Drawing.Size(119, 20);
            this.labelRestriction.TabIndex = 7;
            this.labelRestriction.Text = "Ograniczenie:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(158, 273);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(158, 324);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 9;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(158, 350);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 10;
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(158, 375);
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthorFirstName.TabIndex = 11;
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(158, 401);
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthorLastName.TabIndex = 12;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(158, 427);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(100, 20);
            this.textBoxState.TabIndex = 13;
            // 
            // textBoxRestriction
            // 
            this.textBoxRestriction.Location = new System.Drawing.Point(158, 453);
            this.textBoxRestriction.Name = "textBoxRestriction";
            this.textBoxRestriction.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestriction.TabIndex = 14;
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPersonName.Location = new System.Drawing.Point(8, 298);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(122, 20);
            this.labelPersonName.TabIndex = 15;
            this.labelPersonName.Text = "W posiadaniu:";
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(158, 298);
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonName.TabIndex = 16;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBook.Location = new System.Drawing.Point(310, 281);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(91, 52);
            this.buttonAddBook.TabIndex = 17;
            this.buttonAddBook.Text = "Dodaj książkę";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(310, 343);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 52);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Usuń książkę";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(310, 401);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 55);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(596, 378);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxRole.TabIndex = 50;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRole.Location = new System.Drawing.Point(501, 378);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(51, 20);
            this.labelRole.TabIndex = 49;
            this.labelRole.Text = "Rola:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(596, 352);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 48;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(596, 325);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 47;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAge.Location = new System.Drawing.Point(501, 352);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(53, 20);
            this.labelAge.TabIndex = 46;
            this.labelAge.Text = "Wiek:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(501, 325);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(89, 20);
            this.labelLastName.TabIndex = 45;
            this.labelLastName.Text = "Nazwisko:";
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFisrtName.Location = new System.Drawing.Point(501, 299);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(48, 20);
            this.labelFisrtName.TabIndex = 44;
            this.labelFisrtName.Text = "Imię:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(596, 299);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 43;
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFisrtName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxPersonName);
            this.Controls.Add(this.labelPersonName);
            this.Controls.Add(this.textBoxRestriction);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxAuthorLastName);
            this.Controls.Add(this.textBoxAuthorFirstName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelRestriction);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelAuthorLastName);
            this.Controls.Add(this.labelAuthorFirstName);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "FormWorker";
            this.Text = "FormWorker";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAuthorFirstName;
        private System.Windows.Forms.Label labelAuthorLastName;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelRestriction;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorLastName;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxRestriction;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.TextBox textBoxFirstName;
    }
}