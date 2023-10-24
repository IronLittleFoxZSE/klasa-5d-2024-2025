using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskWpfApp.Validators
{
    public class ValidateAge
    {
        public bool ValidationAge(string userStrAge, out string message)
        {
            if (!ValidationAgeEmpty(userStrAge, out message)
                || !ValidationAgeIsInteger(userStrAge, out message)
                || !ValidationAgeRange(userStrAge, out message))
                return false;

            return true;
        }

        private bool ValidationAgeEmpty(string userStrAge, out string message)
        {
            if (string.IsNullOrWhiteSpace(userStrAge))
            {
                message = "Nie podałeś wieku";
                return false;
            }
            message = "";
            return true;
        }

        private bool ValidationAgeIsInteger(string userStrAge, out string message)
        {
            if (!int.TryParse(userStrAge, out int age))
            {
                message = "Wiek jest nieprawidłową daną";
                return false;
            }
            message = "";
            return true;
        }

        private bool ValidationAgeRange(string userStrAge, out string message)
        {
            int age = int.Parse(userStrAge);
            if (age < 1 || age > 150)
            {
                message = "Wiek jest spoza zakresu <1;150>";
                return false;
            }
            message = "";
            return true;
        }
    }
}
