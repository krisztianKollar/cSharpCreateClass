using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person
    {
        public double Salary { get; set; }
        public string Profession { get; set; }
        public Room EmpRoom { get; set; }


        public Employee(double salary, string profession, Room empRoom, string Name, string BirthDate, Gender gender) : base(Name, BirthDate,  gender)
        {
            Salary = salary;
            Profession = profession;
            EmpRoom = empRoom;
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Date of Birth = " + BirthDate + ", Gender = " + gender + ", Salary = " + Salary + ", Profession = " + Profession + " - in the room no. " + EmpRoom.Number;
        }
    }
}
