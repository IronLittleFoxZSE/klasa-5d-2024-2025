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
