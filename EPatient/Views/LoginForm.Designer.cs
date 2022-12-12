using System.Windows.Forms;

namespace EPatient
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsername = new MetroFramework.Controls.MetroLabel();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Albanian = new System.Windows.Forms.Button();
            this.English = new System.Windows.Forms.Button();
            this.Spanish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(306, 2);
            this.textUsername.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(355, 94);
            this.textUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername.MaxLength = 255;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PromptText = "Username";
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.Size = new System.Drawing.Size(332, 28);
            this.textUsername.TabIndex = 0;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMark = "Username";
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textUsername_Validating);
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(306, 2);
            this.textPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(355, 140);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.MaxLength = 255;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PromptText = "Password";
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(332, 28);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMark = "Password";
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(355, 194);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(104, 17);
            this.checkBoxRememberMe.TabIndex = 2;
            this.checkBoxRememberMe.Text = "Më kujto mua";
            this.checkBoxRememberMe.UseSelectable = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.buttonLogin.Location = new System.Drawing.Point(567, 256);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 37);
            this.buttonLogin.TabIndex = 21;
            this.buttonLogin.Text = "Identifikohu";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(117, 98);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(76, 20);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(117, 145);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.ContainerControl = this;
            // 
            // Albanian
            // 
            this.Albanian.BackColor = System.Drawing.Color.White;
            this.Albanian.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Albanian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Albanian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albanian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Albanian.Image = ((System.Drawing.Image)(resources.GetObject("Albanian.Image")));
            this.Albanian.Location = new System.Drawing.Point(73, 256);
            this.Albanian.Margin = new System.Windows.Forms.Padding(4);
            this.Albanian.Name = "Albanian";
            this.Albanian.Size = new System.Drawing.Size(34, 37);
            this.Albanian.TabIndex = 23;
            this.Albanian.UseVisualStyleBackColor = false;
            this.Albanian.Click += new System.EventHandler(this.Albanian_Click);
            // 
            // English
            // 
            this.English.BackColor = System.Drawing.Color.White;
            this.English.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.English.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.English.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.English.Image = ((System.Drawing.Image)(resources.GetObject("English.Image")));
            this.English.Location = new System.Drawing.Point(31, 256);
            this.English.Margin = new System.Windows.Forms.Padding(4);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(34, 37);
            this.English.TabIndex = 22;
            this.English.UseVisualStyleBackColor = false;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Spanish
            // 
            this.Spanish.BackColor = System.Drawing.Color.White;
            this.Spanish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Spanish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spanish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Spanish.Image = ((System.Drawing.Image)(resources.GetObject("Spanish.Image")));
            this.Spanish.Location = new System.Drawing.Point(115, 256);
            this.Spanish.Margin = new System.Windows.Forms.Padding(4);
            this.Spanish.Name = "Spanish";
            this.Spanish.Size = new System.Drawing.Size(34, 37);
            this.Spanish.TabIndex = 24;
            this.Spanish.UseVisualStyleBackColor = false;
            this.Spanish.Click += new System.EventHandler(this.Spanish_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 324);
            this.Controls.Add(this.Spanish);
            this.Controls.Add(this.Albanian);
            this.Controls.Add(this.English);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textUsername;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroCheckBox checkBoxRememberMe;
        private Button buttonLogin;
        private MetroFramework.Controls.MetroLabel labelUsername;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
        private Button Spanish;
        private Button Albanian;
        private Button English;
    }
}

