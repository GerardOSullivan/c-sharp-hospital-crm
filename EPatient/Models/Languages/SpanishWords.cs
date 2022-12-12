using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    class SpanishWords : Words
    {
        public SpanishWords()
        {
            //Login page words
            errorCredentials = "¡Credenciales incorrectas!";
            errorUsername = "¡Nombre de usuario incorrecto!";
            login = "Acceso";
            rememberMe = "Acuérdate de mí";

            //Admin side panel words
            header = "Panel de administración";
            users = "Usuarios";
            workingHours = "Horas Laborales";
            doctorOnDuty = "Doctor de guardia";
            services = "Servicios";
            building = "Edificios";
            basicReports = "Informes básicos";
            advancedReports = "Informes avanzados";

            //user controls panel words
            add = "Agregar";
            edit = "Editar";
            delete = "Borrar";
            actions = "Comportamiento";
        }
    }
}
