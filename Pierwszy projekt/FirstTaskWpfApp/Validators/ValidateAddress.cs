using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskWpfApp.Validators
{
    public class ValidateAddress
    {
        public bool ValidationAddress(string userAddress, out string message)
        {
            if (!ValidationAddressEmpty(userAddress, out message)
                || !ValidationAddressExists(userAddress, out message))
                return false;
            return true;
        }

        private bool ValidationAddressExists(string userAddress, out string message)
        {

            /*
             if (adres nie istnieje np. sprawdzamy za pomocą map googla)
             {
                message = "Adres nie istnieje";
                return false;
             }
             */
            message = "";
            return true;
        }

        private bool ValidationAddressEmpty(string userAddress, out string message)
        {
            if (string.IsNullOrWhiteSpace(userAddress))
            {
                message = "Nie podałeś adresu";
                return false;
            }
            message = "";
            return true;
        }
    }
}
