using EPatient.Models.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models
{
    public class LoginFormSingleton
    {
        private static LoginFormSingleton singleInstance;
        private static LoginForm loginForm = new LoginForm();
        private LoginFormSingleton() {}

        public static LoginFormSingleton getInstance()
        {
            if(singleInstance == null)
            {
                singleInstance = new LoginFormSingleton();
            }

            return singleInstance;
        }

        public LoginForm getLoginForm()
        {
            return loginForm;
        }

    }
}
