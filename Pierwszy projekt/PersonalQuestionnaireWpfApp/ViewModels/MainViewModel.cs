using PersonalQuestionnaireWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;

namespace PersonalQuestionnaireWpfApp.ViewModels
{
    public class MainViewModel : ObserverVM
    {
        private PersonalDataModel personalDataModel = new PersonalDataModel();

        public string Name
        {
            get { return personalDataModel.name; }
            set
            {
                personalDataModel.name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public bool PizzaWithPineapple
        {
            get { return personalDataModel.isPizzaWithPineapple; }
            set
            {
                personalDataModel.isPizzaWithPineapple = value;
                OnPropertyChanged(nameof(PizzaWithPineapple));
            }
        }

        public bool IsMale
        {
            get { return personalDataModel.isMale; }
            set
            {
                personalDataModel.isMale = value;
                OnPropertyChanged(nameof(IsMale));
            }
        }

        public bool IsFemale
        {
            get { return personalDataModel.isFemale; }
            set
            {
                personalDataModel.isFemale = value;
                OnPropertyChanged(nameof(IsFemale));
            }
        }

        public List<string> ListOfDish
        {
            get { return personalDataModel.listOfDish; }
            set
            {
                personalDataModel.listOfDish = value;
                OnPropertyChanged(nameof(ListOfDish));
            }
        }

        public string SelectedDish
        {
            get { return personalDataModel.selectedDish; }
            set
            {
                personalDataModel.selectedDish = value;
                OnPropertyChanged(nameof(SelectedDish));
            }
        }

        private string questionnaireResult;
        public string QuestionnaireResult
        {
            get { return questionnaireResult; }
            set
            {
                questionnaireResult = value;
                OnPropertyChanged(nameof(QuestionnaireResult));
            }
        }

        private ICommand downloadDataCommand;
        public ICommand DownloadDataComand
        {
            get
            {
                if (downloadDataCommand == null)
                    downloadDataCommand = new RelayCommand<object>(
                        o =>
                        {
                            string result = "";
                            result += "Imię: " + Name + "\n";
                            result += "Pizza z ananasem: " + (PizzaWithPineapple ? "Tak" : "Nie") + "\n";
                            result += "Płeć: " + (IsMale ? "mężczyzna" : "kobiata") + "\n";
                            result += "Ulubione danie: " + SelectedDish + "\n";
                            QuestionnaireResult = result;
                        }
                        );
                return downloadDataCommand;
            }
        }
    }
}
