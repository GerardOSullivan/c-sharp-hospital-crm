using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    public class Words : AdditionalWords
    {
        protected string errorCredentials, errorUsername, login, rememberMe;

        public string getErrorCredentials()
        {
            return errorCredentials;
        }

        public string getLogin()
        {
            return login;
        }

        public string getRememberMe()
        {
            return rememberMe;
        }

        public string getErrorUsername()
        {
            return errorUsername;
        }
    }
}
