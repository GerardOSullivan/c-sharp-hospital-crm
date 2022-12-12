using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPatient.Models;
using Lucene.Net.Support;

namespace EPatient.Utilities
{
    class ProxyLogin : LoginCheck
    {
        private List<string> invalidUserCache = new List<string>();
        private Login login = null;
        private EPatientContext _context = new EPatientContext();

        public bool LoggedIn(string username, string password, bool isRememberMeChecked)
        {
            if (invalidUserCache.Contains(username))
            {
                return false;
            }
            else
            {
                var user = _context.Users.Include("TimeTables").SingleOrDefault(u => u.Username == username);

                if (user == null)
                {
                    invalidUserCache.Add(username);
                    return false;
                }
            }

            if (login == null)
            {
                login = new Login();
            }

            return login.LoggedIn(username,password,isRememberMeChecked);
        }

        public void RememberMe(bool isChecked, string username, string password)
        {
            if(login == null)
            {
                login = new Login();
            }

            login.RememberMe(isChecked,username,password);
        }
    }
}
