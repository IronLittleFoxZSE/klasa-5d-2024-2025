using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;

namespace SimpleCalculatorMVVMWpfApp
{
    public class MainViewModel : ObserverVM
    {
        private int firstNumber;
        public int FirstNumber
        {
            get { return firstNumber; }
            set
            {
                firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        private int secondNumber;
        public int SecondNumber
        {
            get { return secondNumber; }
            set
            {
                secondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }

        private string result;
        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand SubCommand { get; set; }

        private ICommand mulCommand = null;
        public ICommand MulCommand
        {
            get
            {
                if (mulCommand == null)
                    mulCommand = new RelayCommand<object>(
                        o =>
                        {
                            int mul = FirstNumber * SecondNumber;
                            Result = "Wynik mnożenia " + mul.ToString();
                        }
                        );
                return mulCommand;
            }
        }

        private ICommand multiTaskCommand;
        public ICommand MultiTaskCommand
        {
            get
            {
                if (multiTaskCommand == null)
                    multiTaskCommand = new RelayCommand<string>(
                        operationSign =>
                        {
                            switch (operationSign)
                            {
                                case "+":
                                    int sum = FirstNumber + SecondNumber;
                                    Result = "Wynik dodawania " + sum.ToString();
                                    break;
                                case "-":
                                    int sub = FirstNumber - SecondNumber;
                                    Result = "Wynik odejmowania " + sub.ToString();
                                    break;
                                case "*":
                                    int mul = FirstNumber * SecondNumber;
                                    Result = "Wynik mnożenia " + mul.ToString();
                                    break;
                                case "/":
                                    int div = FirstNumber / SecondNumber;
                                    Result = "Wynik dzielenia " + div.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                        );
                return multiTaskCommand;
            }
        }

        public MainViewModel()
        {
            AddCommand = new RelayCommand<object>(Add);

            SubCommand = new RelayCommand<object>((object o) =>
            {
                int sub = FirstNumber - SecondNumber;
                Result = "Wynik odejmowania " + sub.ToString();
            });
        }

        private void Add(object o)
        {
            int sum = FirstNumber + SecondNumber;
            Result = "Wynik dodawania " + sum.ToString();
        }
    }
}
