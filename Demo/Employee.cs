using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable<Employee>, IEquatable<Employee>
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

        public static bool operator <(Employee left, Employee right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Employee left, Employee right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(Employee left, Employee right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(Employee left, Employee right)
        {
            return left.CompareTo(right) >= 0;
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

      
        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;

        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;
            return Age.CompareTo(other.Age);
        }
    }
}
