
namespace LibraryV2.Forms
{
    partial class FormAdmin
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
            this.dataGridViewIdentities = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonAddIdentity = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPerson = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdentities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIdentities
            // 
            this.dataGridViewIdentities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdentities.Location = new System.Drawing.Point(389, 12);
            this.dataGridViewIdentities.Name = "dataGridViewIdentities";
            this.dataGridViewIdentities.Size = new System.Drawing.Size(399, 150);
            this.dataGridViewIdentities.TabIndex = 0;
            this.dataGridViewIdentities.SelectionChanged += new System.EventHandler(this.dataGridViewIdentities_SelectionChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(396, 174);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(62, 23);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Imię:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(396, 203);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(111, 23);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Nazwisko:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAge.Location = new System.Drawing.Point(396, 236);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(68, 23);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Wiek:";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImage.Location = new System.Drawing.Point(396, 272);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(89, 23);
            this.labelImage.TabIndex = 4;
            this.labelImage.Text = "Zdjęcie:";
            // 
            // buttonAddIdentity
            // 
            this.buttonAddIdentity.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddIdentity.Location = new System.Drawing.Point(603, 311);
            this.buttonAddIdentity.Name = "buttonAddIdentity";
            this.buttonAddIdentity.Size = new System.Drawing.Size(182, 31);
            this.buttonAddIdentity.TabIndex = 5;
            this.buttonAddIdentity.Text = "Dodaj osobę";
            this.buttonAddIdentity.UseVisualStyleBackColor = true;
            this.buttonAddIdentity.Click += new System.EventHandler(this.buttonAddIdentity_Click);
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddImage.Location = new System.Drawing.Point(400, 311);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(182, 31);
            this.buttonAddImage.TabIndex = 6;
            this.buttonAddImage.Text = "Wybierz zdjęcie";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFirstName.Location = new System.Drawing.Point(505, 171);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(216, 29);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLastName.Location = new System.Drawing.Point(505, 206);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(216, 29);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAge.Location = new System.Drawing.Point(505, 241);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(216, 29);
            this.textBoxAge.TabIndex = 9;
            // 
            // textBoxImage
            // 
            this.textBoxImage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImage.Location = new System.Drawing.Point(505, 276);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(216, 29);
            this.textBoxImage.TabIndex = 10;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(400, 348);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(385, 197);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 11;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(371, 150);
            this.dataGridViewUsers.TabIndex = 12;
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(9, 209);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(38, 23);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "Id:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(9, 244);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 23);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(9, 279);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 23);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Hasło:";
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPerson.Location = new System.Drawing.Point(9, 313);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(102, 23);
            this.labelPerson.TabIndex = 16;
            this.labelPerson.Text = "OsobaID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxId.Location = new System.Drawing.Point(116, 206);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(216, 29);
            this.textBoxId.TabIndex = 17;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(116, 241);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 29);
            this.textBoxLogin.TabIndex = 18;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(117, 276);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(216, 29);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPerson.Location = new System.Drawing.Point(117, 311);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(216, 29);
            this.textBoxPerson.TabIndex = 20;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddUser.Location = new System.Drawing.Point(115, 381);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(216, 47);
            this.buttonAddUser.TabIndex = 21;
            this.buttonAddUser.Text = "Dodaj użytkownika";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(115, 434);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(216, 47);
            this.buttonDeleteUser.TabIndex = 22;
            this.buttonDeleteUser.Text = "Usuń użytkownika";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditUser.Location = new System.Drawing.Point(116, 487);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(216, 47);
            this.buttonEditUser.TabIndex = 23;
            this.buttonEditUser.Text = "Edytuj użytkownika";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRole.Location = new System.Drawing.Point(13, 348);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(85, 23);
            this.labelRole.TabIndex = 24;
            this.labelRole.Text = "Rodzaj:";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRole.Location = new System.Drawing.Point(117, 346);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(216, 29);
            this.textBoxRole.TabIndex = 25;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.textBoxPerson);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.textBoxImage);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.buttonAddIdentity);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dataGridViewIdentities);
            this.Name = "FormAdmin";
            this.Text = "Okno Admina";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdentities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIdentities;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonAddIdentity;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxRole;
    }
}