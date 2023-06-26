using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_struktury
{
    class Program
    {
        struct Student
        {
            public string Imie;
            public string Nazwisko;
            public int NumerAlbumu;
            public string Kierunek;
            public string Email;
        }

        struct Przedmiot
        {
            public string Nazwa;
            public string Kod;
            public string Opis;
            public int ECTS;
            public string Prowadzacy;
        }

        struct NauczycielAkademicki
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
