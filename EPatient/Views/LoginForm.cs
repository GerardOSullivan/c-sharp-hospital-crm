using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using EPatient.Models;
using EPatient.Models.Languages;
using EPatient.Models.Auth;
using EPatient.Utilities;
using EPatient.Views;

namespace EPatient
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private readonly ProxyLogin _helper;
        public static LanguageFactory langFactory = new LanguageFactory();
        public static Words language = langFactory.getLanguage("Albanian");
        private LanguageState languageState = new LanguageState();

        public LoginForm()
        {
            InitializeComponent();
            _helper = new ProxyLogin();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (_helper.LoggedIn(textUsername.Text, textPassword.Text, checkBoxRememberMe.Checked))
                {
                    Form mainForm = null;

                    switch (AuthUser.Model.RoleId)
                    {
                        case Role.Admin:
                            mainForm = new AdminForm();
                            break;
                        case Role.Operator:
                            mainForm = new OperatorForm();
                            break;
                        default:
                            mainForm = new StaffForm();
                            break;

                    }
                    
                    this.Hide();
                    mainForm.Show();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, language.getErrorCredentials(), "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }         
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Activate();
            if (Properties.Settings.Default.LoginFormRememberMe)
            {
                textUsername.Text = Properties.Settings.Default.LoginFormUsername;
                textPassword.Text = Properties.Settings.Default.LoginFormPassword;
                checkBoxRememberMe.Checked = Properties.Settings.Default.LoginFormRememberMe;
            }
        }

        private void textUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                e.Cancel = true;
                textUsername.Focus();
                loginErrorProvider.SetError(textUsername, language.getErrorUsername());
            }
            else
            {
                e.Cancel = false;
                loginErrorProvider.SetError(textUsername, language.getErrorUsername());
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit();
        }

        private void English_Click(object sender, EventArgs e)
        {
            languageState.setLanguageState("English");
            Update_Values();
        }

        private void Albanian_Click(object sender, EventArgs e)
        {
            languageState.setLanguageState("Albanian");
            Update_Values();
        }

        private void Spanish_Click(object sender, EventArgs e)
        {
            languageState.setLanguageState("Spanish");
            Update_Values();
        }

        private void Update_Values()
        {
            language = langFactory.getLanguage(languageState.getLanguageState());
            checkBoxRememberMe.Text = language.getRememberMe();
            buttonLogin.Text = language.getLogin();
        }
    }
}
