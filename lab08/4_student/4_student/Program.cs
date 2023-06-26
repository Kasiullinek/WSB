using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_student
{
    class Program
    {
        enum TypPlci
        {
            Kobieta = 1,
            Mezczyzna,
        }
        struct Student
        {
            public string Nazwisko;
            public int NrAlbumu;
            public double Ocena;
            public TypPlci Plec;
        }

        static void Wypelnij(ref Student Student, string Nazwisko, int NrAlbumu, double Ocena, TypPlci Plec)
        {
            Student.Nazwisko = Nazwisko;

            if (NrAlbumu > 0 && NrAlbumu < 1000000) //numer albumu składa się z max 6 cyfr
            {
                Student.NrAlbumu = NrAlbumu;
            }
            else
            {
                Student.NrAlbumu = 0;
            }

            if (Ocena >= 2 && Ocena <= 5)
            {
                Student.Ocena = Ocena;
            }
            else if (Ocena < 2)
            {
                Student.Ocena = 2;
            }
            else
            {
                Student.Ocena = 5;
            }

            Student.Plec = Plec;

        }

        static double WyliczSredniaGrupy(Student[] grupa)
        {
            double sumaOcen = 0;
            int liczbaStudentow = grupa.Length;

            foreach(Student student in grupa)
            {
                sumaOcen += (double)student.Ocena;
            }

            return sumaOcen / liczbaStudentow;
        }

        static void Wyswietl (Student student)
        {
            Console.WriteLine("Nazwisko: {0,10} | Numer albumu: {1,6} | Ocena: {2,4} | Płeć: {3,9} |", student.Nazwisko, student.NrAlbumu, student.Ocena, student.Plec);
            Console.WriteLine("---------------------+----------------------+-------------+-----------------+");
        }
        static void Main(string[] args)
        {
            Student[] studenci = new Student[5];

            Wypelnij(ref studenci[0], "Kowalski", 777777, 5.7, TypPlci.Mezczyzna);
            Wypelnij(ref studenci[1], "Smith", 462475, 4.5, TypPlci.Mezczyzna);
            Wypelnij(ref studenci[2], "Nowak", 7865732, 4, TypPlci.Kobieta);
            Wypelnij(ref studenci[3], "Mazur", 546746, 1.2, TypPlci.Kobieta);
            Wypelnij(ref studenci[4], "Dudek", 234676, 3, TypPlci.Mezczyzna);

            double srednia = WyliczSredniaGrupy(studenci);

            foreach (Student student in studenci)
            {
                Wyswietl(student);
            }

            Console.WriteLine("\nŚrednia grupy: {0}",srednia);

            Console.Read();
        }
    }
}
