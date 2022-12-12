using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Utilities
{
    public interface LoginCheck
    {
        bool LoggedIn(string username, string password, bool isRememberMeChecked);

        void RememberMe(bool isChecked, string username, string password);
    }
}
