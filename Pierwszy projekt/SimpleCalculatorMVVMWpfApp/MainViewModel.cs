using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsWpf;

namespace SimpleCalculatorMVVMWpfApp
{
    public class MainViewModel : ObserverVM
    {
        private int firsNumber;
        public int FirstNumber
        {
            get { return firsNumber; }
            set
            {
                firsNumber = value;
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

        private int result;
        public int Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
    }
}
