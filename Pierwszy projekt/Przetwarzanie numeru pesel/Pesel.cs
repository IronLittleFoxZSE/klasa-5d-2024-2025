using System;
using System.Collections.Generic;
using System.Text;

namespace Przetwarzanie_numeru_pesel
{
    class Pesel
    {
        private string numerPesel;
        public char Plec
        {
            get
            {

                return numerPesel[9];
            }
        }

        public string PlecOpisowa
        {
            get
            {
                if (int.Parse(numerPesel[9].ToString()) %2 == 1)
                        return "mężczyzna";
                else
                    return "kobieta";
            }
        }

        public Pesel(string numer)
        {
            numerPesel = numer;

            WalidacjaDlugosciLancuchaZnakow();
            WalidacjaSameCyfry();

            //....

        }

        private void WalidacjaDlugosciLancuchaZnakow()
        {
            if (numerPesel.Length != 11)
                throw new Exception("Numer ma nieprawidłową ilość znaków");
        }

        private void WalidacjaSameCyfry()
        {
            for (int i = 0; i < numerPesel.Length; i++)
            {
                if (!(numerPesel[i] >= '0' && numerPesel[i] <= '9'))
                    throw new Exception("Numer PESEL nie składa się z samych cyfr");

            }
        }
    }
}

