using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    class LanguageState
    {
        private static String languageState = "Albanian";
        public void setLanguageState(string state)
        {
            languageState = state;
        }

        public string getLanguageState()
        {
            return languageState;
        }

        public Words selectedLanguage()
        {
            switch (this.getLanguageState())
            {
                case "English":
                    return new EnglishWords();
                case "Albanian":
                    return new AlbanianWords();
                case "Spanish":
                    return new SpanishWords();
                default:
                    return new AlbanianWords();
            }
        }
    }
}
