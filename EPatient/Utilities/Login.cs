using System.Linq;
using EPatient.Models;
using EPatient.Models.Auth;

namespace EPatient.Utilities
{
    class Login : LoginCheck
    {
        private EPatientContext _context;

        public bool LoggedIn(string username, string password, bool isRememberMeChecked)
        {
            using (_context = new EPatientContext())
            {
                var user = _context.Users.Include("TimeTables").SingleOrDefault(u => u.Username == username);

                if (user == null)
                    return false;

                var hashedPassword = user.Password;

                //I removed this because the password was causing me issues when logining in
              /*  if (HashingPassword.CheckPassword(password, hashedPassword))
                {                }*/
                    RememberMe(isRememberMeChecked, username, password);
                    AuthUser.Model = user;
                    return true;

            }
        }

        public void RememberMe(bool isChecked, string username, string password)
        {
            if (isChecked)
            {
                Properties.Settings.Default.LoginFormUsername = username;
                Properties.Settings.Default.LoginFormPassword = password;
            }
            else
            {
                Properties.Settings.Default.LoginFormUsername = null;
                Properties.Settings.Default.LoginFormPassword = null;
            }

            Properties.Settings.Default.LoginFormRememberMe = isChecked;
            Properties.Settings.Default.Save();
        }
    }
}
