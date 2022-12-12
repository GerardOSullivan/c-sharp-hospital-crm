using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    public class AdditionalWords
    {
        protected string header, users, workingHours, doctorOnDuty, services, building, basicReports, advancedReports, add, edit, delete, actions;

        public string getHeader()
        {
            return header;
        }

        public string getUsers()
        {
            return users;
        }

        public string getWorkingHours()
        {
            return workingHours;
        }

        public string getDoctorOnDuty()
        {
            return doctorOnDuty;
        }
        public string getServices()
        {
            return services;
        }

        public string getBuilding()
        {
            return building;
        }

        public string getBasicReports()
        {
            return basicReports;
        }
        public string getAdvancedReports()
        {
            return advancedReports;
        }

        public string getAdd()
        {
            return add;
        }
        public string getEdit()
        {
            return edit;
        }
        public string getDelete()
        {
            return delete;
        }
        public string getActions()
        {
            return actions;
        }

    }
}
