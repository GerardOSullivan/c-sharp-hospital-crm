using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models.Languages
{
    public class LangugageFactory
    {
        public LangugageFactory() { }

        public Words getLanguage(string language)
        {
            if(language == "English")
            {
                return new EnglishWords();
            }
            else if(language == "Spanish")
            {
                return new SpanishWords();
            }
            else
            {
                return new AlbanianWords();
            }
        }
    }
}
