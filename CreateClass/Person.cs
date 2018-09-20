using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{

    public class Person
    {
        public enum Gender
        {
            Male,
            Female
        }

        public string Name { get; set; }
        public string BirthDate { get; set; }
        protected Gender gender;

        public Person(string name, string birthDate, Gender gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Date of Birth = " + BirthDate + ", Gender = " + gender;
        }
    }

}