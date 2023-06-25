using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_struktury
{
    class Program
    {
        public struct Student
        {
            public string Imie;
            public string Nazwisko;
            public int NumerAlbumu;
            public string Kierunek;
            public string Email;
        }

        public struct Przedmiot
        {
            public string Nazwa;
            public string Kod;
            public string Opis;
            public int ECTS;
            public string Prowadzacy;
        }

        public struct NauczycielAkademicki
        {
            public string Imie;
            public string Nazwisko;
            public string TytulNaukowy;
            public string Email;
        }
        static void Main(string[] args)
        {
        }
    }
}
