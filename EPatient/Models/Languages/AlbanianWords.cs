using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    class AlbanianWords : Words
    {
        public AlbanianWords()
        {
            //Login page words
            errorCredentials = "Kredenciale te gabuara!";
            errorUsername = "Ju lutem vendosni username";
            login = "Identifikohu";
            rememberMe = "Më kujto mua";

            //Admin side panel words
            header = "Paneli Administratorit";
            users = "Perdorues";
            workingHours = "Orare";
            doctorOnDuty = "Mjeku Roje";
            services = "Sherbime";
            building = "Pavilion";
            basicReports = "Raporte Baze";
            advancedReports = "Raporte te Avancuara";

            //user controls panel words
            add = "Krijo";
            edit = "Modifiko";
            delete = "Elemino";
            actions = "Veprime";
        }
    }
}
