
namespace Library.Forms
{
    partial class FormLogin
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
            this.buttonLoggin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelWorkerLogin = new System.Windows.Forms.Label();
            this.labelWorkerPassword = new System.Windows.Forms.Label();
            this.labelClientLogin1 = new System.Windows.Forms.Label();
            this.labelClientPassword1 = new System.Windows.Forms.Label();
            this.labelClientLogin2 = new System.Windows.Forms.Label();
            this.labelClientPassword2 = new System.Windows.Forms.Label();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.labelPasswordText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoggin
            // 
            this.buttonLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoggin.Location = new System.Drawing.Point(133, 102);
            this.buttonLoggin.Name = "buttonLoggin";
            this.buttonLoggin.Size = new System.Drawing.Size(90, 34);
            this.buttonLoggin.TabIndex = 9;
            this.buttonLoggin.Text = "Zaloguj się";
            this.buttonLoggin.UseVisualStyleBackColor = true;
            this.buttonLoggin.Click += new System.EventHandler(this.buttonLoggin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(161, 76);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(161, 45);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(97, 76);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Hasło:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(97, 45);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 20);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Login:";
            // 
            // labelWorkerLogin
            // 
            this.labelWorkerLogin.AutoSize = true;
            this.labelWorkerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkerLogin.Location = new System.Drawing.Point(112, 202);
            this.labelWorkerLogin.Name = "labelWorkerLogin";
            this.labelWorkerLogin.Size = new System.Drawing.Size(67, 20);
            this.labelWorkerLogin.TabIndex = 10;
            this.labelWorkerLogin.Text = "admin1";
            // 
            // labelWorkerPassword
            // 
            this.labelWorkerPassword.AutoSize = true;
            this.labelWorkerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkerPassword.Location = new System.Drawing.Point(113, 162);
            this.labelWorkerPassword.Name = "labelWorkerPassword";
            this.labelWorkerPassword.Size = new System.Drawing.Size(67, 20);
            this.labelWorkerPassword.TabIndex = 11;
            this.labelWorkerPassword.Text = "admin1";
            // 
            // labelClientLogin1
            // 
            this.labelClientLogin1.AutoSize = true;
            this.labelClientLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClientLogin1.Location = new System.Drawing.Point(186, 162);
            this.labelClientLogin1.Name = "labelClientLogin1";
            this.labelClientLogin1.Size = new System.Drawing.Size(67, 20);
            this.labelClientLogin1.TabIndex = 12;
            this.labelClientLogin1.Text = "admin2";
            // 
            // labelClientPassword1
            // 
            this.labelClientPassword1.AutoSize = true;
            this.labelClientPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClientPassword1.Location = new System.Drawing.Point(186, 202);
            this.labelClientPassword1.Name = "labelClientPassword1";
            this.labelClientPassword1.Size = new System.Drawing.Size(67, 20);
            this.labelClientPassword1.TabIndex = 13;
            this.labelClientPassword1.Text = "admin2";
            // 
            // labelClientLogin2
            // 
            this.labelClientLogin2.AutoSize = true;
            this.labelClientLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClientLogin2.Location = new System.Drawing.Point(259, 202);
            this.labelClientLogin2.Name = "labelClientLogin2";
            this.labelClientLogin2.Size = new System.Drawing.Size(67, 20);
            this.labelClientLogin2.TabIndex = 14;
            this.labelClientLogin2.Text = "admin3";
            // 
            // labelClientPassword2
            // 
            this.labelClientPassword2.AutoSize = true;
            this.labelClientPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClientPassword2.Location = new System.Drawing.Point(259, 162);
            this.labelClientPassword2.Name = "labelClientPassword2";
            this.labelClientPassword2.Size = new System.Drawing.Size(67, 20);
            this.labelClientPassword2.TabIndex = 15;
            this.labelClientPassword2.Text = "admin3";
            // 
            // labelLoginText
            // 
            this.labelLoginText.AutoSize = true;
            this.labelLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginText.Location = new System.Drawing.Point(12, 161);
            this.labelLoginText.Name = "labelLoginText";
            this.labelLoginText.Size = new System.Drawing.Size(58, 20);
            this.labelLoginText.TabIndex = 16;
            this.labelLoginText.Text = "Login:";
            // 
            // labelPasswordText
            // 
            this.labelPasswordText.AutoSize = true;
            this.labelPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordText.Location = new System.Drawing.Point(12, 202);
            this.labelPasswordText.Name = "labelPasswordText";
            this.labelPasswordText.Size = new System.Drawing.Size(91, 20);
            this.labelPasswordText.TabIndex = 17;
            this.labelPasswordText.Text = "Password:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 250);
            this.Controls.Add(this.labelPasswordText);
            this.Controls.Add(this.labelLoginText);
            this.Controls.Add(this.labelClientPassword2);
            this.Controls.Add(this.labelClientLogin2);
            this.Controls.Add(this.labelClientPassword1);
            this.Controls.Add(this.labelClientLogin1);
            this.Controls.Add(this.labelWorkerPassword);
            this.Controls.Add(this.labelWorkerLogin);
            this.Controls.Add(this.buttonLoggin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoggin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelWorkerLogin;
        private System.Windows.Forms.Label labelWorkerPassword;
        private System.Windows.Forms.Label labelClientLogin1;
        private System.Windows.Forms.Label labelClientPassword1;
        private System.Windows.Forms.Label labelClientLogin2;
        private System.Windows.Forms.Label labelClientPassword2;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Label labelPasswordText;
    }
}