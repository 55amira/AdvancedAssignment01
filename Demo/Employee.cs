using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        public int Id  { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public static bool operator ==(Employee left, Employee right)
        {
            return left.Id ==right.Id && left.Name == right.Name && left.Age == right.Age && left.Salary == right.Salary;
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return left.Id != right.Id && left.Name != right.Name && left.Age != right.Age && left.Salary != right.Salary;
        }

        public override bool Equals(object? obj)
        {
            Employee employee =(Employee)obj;   
            return this == employee;
        }
        public override string ToString()
        {
            return $"id : {Id} , name : {Name} , age : {Age} , salar : {Salary}";
        }
    }
}
