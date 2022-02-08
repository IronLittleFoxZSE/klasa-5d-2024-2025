using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaneOsobowe
{
    class Osoba
    {
        //public:
        public string imie;
        public string nazwisko;
        private byte wiek;

        public byte Wiek //(byte value)
        {
            set
            {
                if (value < 130)
                    wiek = value;
            }

            get
            {
                return wiek;
            }
        }

        public void SetWiek(byte w)
        {
            if (w < 130)
                wiek = w;
        }

        public byte GetWiek()
        {
            return wiek;
        }
    }
}
