using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    class EnglishWords : Words
    {
        public EnglishWords()
        {
            //Login page words
            errorCredentials = "Wrong credentials!";
            errorUsername = "Wrong username!";
            login = "Login";
            rememberMe = "Remember me";

            //Admin side panel words
            header = "Administration Panel";
            users = "Users";
            doctorOnDuty = "Doctor on duty";
            services = "Services";
            building = "Buildings";
            workingHours = "Working hours";
            basicReports = "Basic reports";
            advancedReports = "Advanced reports";

            //user controls panel words
            add = "Add";
            edit = "Edit";
            delete = "Delete";
            actions = "Actions";
        }
    }
}
