using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulamki
{
    class Ulamek
    {
        private int licznik;
        private int mianownik;

        public Ulamek(int l, int m)
        {
            licznik = l;
            mianownik = m;
        }

        #region Operacje arytmetyczne

        public static Ulamek operator +(Ulamek ulamek1, Ulamek ulamek2)
        {
            int licz = ulamek1.licznik * ulamek2.mianownik + ulamek2.licznik * ulamek1.mianownik;

            Ulamek wynik = new Ulamek(licz, ulamek1.mianownik * ulamek2.mianownik);
            return wynik;
        }

        public static Ulamek operator -(Ulamek ulamek1, Ulamek ulamek2)
        {
            int licz = ulamek1.licznik * ulamek2.mianownik - ulamek2.licznik * ulamek1.mianownik;

            Ulamek wynik = new Ulamek(licz, ulamek1.mianownik * ulamek2.mianownik);
            return wynik;
        }

        public static Ulamek operator *(Ulamek ulamek1, Ulamek ulamek2)
        {
            Ulamek wynik = new Ulamek(ulamek1.licznik * ulamek2.licznik, ulamek1.mianownik * ulamek2.mianownik);
            return wynik;
        }

        public static Ulamek operator /(Ulamek ulamek1, Ulamek ulamek2)
        {
            Ulamek wynik = new Ulamek(ulamek1.licznik * ulamek2.mianownik, ulamek1.mianownik * ulamek2.licznik);
            return wynik;
        }

        #endregion

        #region Operatory porównania

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            int l1 = u1.licznik * u2.mianownik;
            int l2 = u2.licznik * u1.mianownik;
            return l1 > l2;
        }

        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            int l1 = u1.licznik * u2.mianownik;
            int l2 = u2.licznik * u1.mianownik;
            return l1 < l2;
        }

        public static bool operator >=(Ulamek u1, Ulamek u2)
        {
            int l1 = u1.licznik * u2.mianownik;
            int l2 = u2.licznik * u1.mianownik;
            return l1 >= l2;
        }

        public static bool operator <=(Ulamek u1, Ulamek u2)
        {
            int l1 = u1.licznik * u2.mianownik;
            int l2 = u2.licznik * u1.mianownik;
            return l1 <= l2;
        }

        public static bool operator ==(Ulamek u1, Ulamek u2)
        {
            int l1 = u1.licznik * u2.mianownik;
            int l2 = u2.licznik * u1.mianownik;
            return l1 == l2;
        }

        public static bool operator !=(Ulamek u1, Ulamek u2)
        {
            int l1 = u1.licznik * u2.mianownik;
            int l2 = u2.licznik * u1.mianownik;
            return l1 != l2;
        }

        #endregion

        #region Metody konwertujące

        public static implicit operator Ulamek(int liczba)
        {
            return new Ulamek(liczba, 1);
        }

        public static implicit operator int(Ulamek u1)
        {
            return u1.licznik / u1.mianownik;
        }

        public static implicit operator double(Ulamek u1)
        {
            return 1.0 * u1.licznik / u1.mianownik;
        }

        #endregion

        private void SkrocUlamek()
        {
            
        }

        public override string ToString()
        {
            return licznik + "/" + mianownik; 
        }

    }
}
