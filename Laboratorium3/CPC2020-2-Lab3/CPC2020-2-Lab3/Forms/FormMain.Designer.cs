
namespace CPC2020_2_Lab3.Forms
{
    partial class FormMain
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.labelBooks = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxYearOfPublication = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelYearOfPublication = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonClearTextBoxes = new System.Windows.Forms.Button();
            this.labelLastAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(9, 30);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(582, 198);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(267, 332);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(98, 24);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "Dodaj książkę";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(267, 244);
            this.buttonDeleteBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(98, 24);
            this.buttonDeleteBook.TabIndex = 2;
            this.buttonDeleteBook.Text = "Usuń książkę";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(267, 273);
            this.buttonEditBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(98, 24);
            this.buttonEditBook.TabIndex = 3;
            this.buttonEditBook.Text = "Edytuj książkę";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(9, 7);
            this.labelBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(40, 13);
            this.labelBooks.TabIndex = 4;
            this.labelBooks.Text = "Książki";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(88, 266);
            this.textBoxBookTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(151, 20);
            this.textBoxBookTitle.TabIndex = 5;
            // 
            // textBoxYearOfPublication
            // 
            this.textBoxYearOfPublication.Location = new System.Drawing.Point(88, 289);
            this.textBoxYearOfPublication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxYearOfPublication.Name = "textBoxYearOfPublication";
            this.textBoxYearOfPublication.Size = new System.Drawing.Size(151, 20);
            this.textBoxYearOfPublication.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(88, 311);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 20);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(88, 334);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(151, 20);
            this.textBoxGenre.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(88, 359);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(68, 20);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(170, 359);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(68, 20);
            this.textBoxLastName.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(7, 269);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Tytuł:";
            // 
            // labelYearOfPublication
            // 
            this.labelYearOfPublication.AutoSize = true;
            this.labelYearOfPublication.Location = new System.Drawing.Point(7, 292);
            this.labelYearOfPublication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYearOfPublication.Name = "labelYearOfPublication";
            this.labelYearOfPublication.Size = new System.Drawing.Size(72, 13);
            this.labelYearOfPublication.TabIndex = 12;
            this.labelYearOfPublication.Text = "Rok wydania:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(7, 314);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Cena:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(7, 336);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(51, 13);
            this.labelGenre.TabIndex = 14;
            this.labelGenre.Text = "Gatunek:";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(7, 362);
            this.labelAuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(81, 13);
            this.labelAuthorName.TabIndex = 15;
            this.labelAuthorName.Text = "Imię i nazwisko:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(7, 246);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(88, 244);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(151, 20);
            this.textBoxId.TabIndex = 16;
            // 
            // buttonClearTextBoxes
            // 
            this.buttonClearTextBoxes.Location = new System.Drawing.Point(267, 302);
            this.buttonClearTextBoxes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearTextBoxes.Name = "buttonClearTextBoxes";
            this.buttonClearTextBoxes.Size = new System.Drawing.Size(98, 24);
            this.buttonClearTextBoxes.TabIndex = 18;
            this.buttonClearTextBoxes.Text = "Wyczyść pola";
            this.buttonClearTextBoxes.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxes.Click += new System.EventHandler(this.buttonClearTextBoxes_Click);
            // 
            // labelLastAction
            // 
            this.labelLastAction.AutoSize = true;
            this.labelLastAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastAction.Location = new System.Drawing.Point(4, 395);
            this.labelLastAction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastAction.Name = "labelLastAction";
            this.labelLastAction.Size = new System.Drawing.Size(302, 42);
            this.labelLastAction.TabIndex = 19;
            this.labelLastAction.Text = "Ostatnia akcja...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 441);
            this.Controls.Add(this.labelLastAction);
            this.Controls.Add(this.buttonClearTextBoxes);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYearOfPublication);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxYearOfPublication);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Okno główne";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxYearOfPublication;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelYearOfPublication;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonClearTextBoxes;
        private System.Windows.Forms.Label labelLastAction;
    }
}

