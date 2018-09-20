using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jani = new Employee(20000, "Spaceman", new Room(6), "Jani", "1977.12.31.", Person.Gender.Male);
            Person kati = new Person("Kati", "2000.01.01.", Person.Gender.Female);

            System.Console.WriteLine(jani);
            System.Console.WriteLine(kati);
        }
    }
}