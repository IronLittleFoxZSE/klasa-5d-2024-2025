using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskWpfApp.Validators
{
    public  class Validate
    {
        public bool Validation(string userName, string userStrAge, string userAddress, out string message)
        {
            if (!new ValidateName().ValidationName(userName, out message)
                || !new ValidateAge().ValidationAge(userStrAge, out message)
                || !new ValidateAddress().ValidationAddress(userAddress, out message))
                return false;

            return true;
        }
    }
}
