using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskWpfApp.Validators
{
    public class ValidateName
    { 
        public bool ValidationName(string userName, out string message)
        {
            if (!ValidationNameEmpty(userName, out message))
                return false;
            return true;
        }

        private bool ValidationNameEmpty(string userName, out string message)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                message = "Nie podałeś imienia";
                return false;
            }
            message = "";
            return true;
        }
    }
}
