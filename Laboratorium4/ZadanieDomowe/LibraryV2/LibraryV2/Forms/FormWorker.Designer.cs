
namespace LibraryV2.Forms
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAuthorsFirstName = new System.Windows.Forms.Label();
            this.labelAuthorsLastName = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelRestriction = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthorsFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorsLastName = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxRestriction = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(850, 150);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(12, 201);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(38, 23);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUser.Location = new System.Drawing.Point(12, 233);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(134, 23);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Użytkownik:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(12, 268);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(69, 23);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Tytuł:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGenre.Location = new System.Drawing.Point(12, 303);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(100, 23);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Gatunek:";
            // 
            // labelAuthorsFirstName
            // 
            this.labelAuthorsFirstName.AutoSize = true;
            this.labelAuthorsFirstName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthorsFirstName.Location = new System.Drawing.Point(287, 198);
            this.labelAuthorsFirstName.Name = "labelAuthorsFirstName";
            this.labelAuthorsFirstName.Size = new System.Drawing.Size(132, 23);
            this.labelAuthorsFirstName.TabIndex = 5;
            this.labelAuthorsFirstName.Text = "Imię autora:";
            // 
            // labelAuthorsLastName
            // 
            this.labelAuthorsLastName.AutoSize = true;
            this.labelAuthorsLastName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthorsLastName.Location = new System.Drawing.Point(287, 233);
            this.labelAuthorsLastName.Name = "labelAuthorsLastName";
            this.labelAuthorsLastName.Size = new System.Drawing.Size(181, 23);
            this.labelAuthorsLastName.TabIndex = 6;
            this.labelAuthorsLastName.Text = "Nazwisko autora:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelState.Location = new System.Drawing.Point(287, 268);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(61, 23);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "Stan:";
            // 
            // labelRestriction
            // 
            this.labelRestriction.AutoSize = true;
            this.labelRestriction.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRestriction.Location = new System.Drawing.Point(287, 303);
            this.labelRestriction.Name = "labelRestriction";
            this.labelRestriction.Size = new System.Drawing.Size(147, 23);
            this.labelRestriction.TabIndex = 8;
            this.labelRestriction.Text = "Ograniczenie:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxId.Location = new System.Drawing.Point(148, 195);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(133, 29);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUser.Location = new System.Drawing.Point(148, 230);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(133, 29);
            this.textBoxUser.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(148, 265);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(133, 29);
            this.textBoxTitle.TabIndex = 11;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGenre.Location = new System.Drawing.Point(148, 300);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(133, 29);
            this.textBoxGenre.TabIndex = 12;
            // 
            // textBoxAuthorsFirstName
            // 
            this.textBoxAuthorsFirstName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAuthorsFirstName.Location = new System.Drawing.Point(471, 198);
            this.textBoxAuthorsFirstName.Name = "textBoxAuthorsFirstName";
            this.textBoxAuthorsFirstName.Size = new System.Drawing.Size(133, 29);
            this.textBoxAuthorsFirstName.TabIndex = 13;
            // 
            // textBoxAuthorsLastName
            // 
            this.textBoxAuthorsLastName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAuthorsLastName.Location = new System.Drawing.Point(471, 230);
            this.textBoxAuthorsLastName.Name = "textBoxAuthorsLastName";
            this.textBoxAuthorsLastName.Size = new System.Drawing.Size(133, 29);
            this.textBoxAuthorsLastName.TabIndex = 14;
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxState.Location = new System.Drawing.Point(471, 265);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(133, 29);
            this.textBoxState.TabIndex = 15;
            // 
            // textBoxRestriction
            // 
            this.textBoxRestriction.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRestriction.Location = new System.Drawing.Point(471, 300);
            this.textBoxRestriction.Name = "textBoxRestriction";
            this.textBoxRestriction.Size = new System.Drawing.Size(133, 29);
            this.textBoxRestriction.TabIndex = 16;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBook.Location = new System.Drawing.Point(616, 190);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(246, 44);
            this.buttonAddBook.TabIndex = 17;
            this.buttonAddBook.Text = "Dodaj książkę";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteBook.Location = new System.Drawing.Point(616, 240);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(246, 44);
            this.buttonDeleteBook.TabIndex = 18;
            this.buttonDeleteBook.Text = "Usuń książkę";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditBook.Location = new System.Drawing.Point(616, 290);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(246, 44);
            this.buttonEditBook.TabIndex = 19;
            this.buttonEditBook.Text = "Edytuj książkę";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 342);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxRestriction);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxAuthorsLastName);
            this.Controls.Add(this.textBoxAuthorsFirstName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelRestriction);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelAuthorsLastName);
            this.Controls.Add(this.labelAuthorsFirstName);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormWorker";
            this.Text = "Okno Pracownika";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAuthorsFirstName;
        private System.Windows.Forms.Label labelAuthorsLastName;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelRestriction;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthorsFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorsLastName;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxRestriction;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonEditBook;
    }
}