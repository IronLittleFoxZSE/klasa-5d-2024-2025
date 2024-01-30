using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalQuestionnaireWpfApp.Models
{
    public struct PersonalDataModel
    {
        public string name;
        public bool isPizzaWithPineapple;
        public bool isMale;
        public bool isFemale;
        public List<string> listOfDish;
        public string selectedDish;

        public PersonalDataModel()
        {
            name = "";
            isPizzaWithPineapple = false;
            isMale = true;
            isFemale = false;
            listOfDish = new List<string>()
            {
                "rosół", "schabowy", "mielone", "kebab"
            };
            selectedDish = listOfDish.First();
        }
    }
}
