using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.day5.classwork
{
    internal class Employee
    {
        int IdNo;
        string Name;
        static int id;
        public Employee()
        {
            Console.WriteLine("Default constructor");
            this.IdNo = 1000;
            this.Name = "admin";

        }
        public Employee(int IdNo)
        {
            Console.WriteLine("Parametric constructor");
            this.IdNo = IdNo;

        }
        public Employee(string Name)
        {
            Console.WriteLine("para constr");
            this.Name = Name;

        }
        public Employee(int IdNo, string Name )
        {
            Console.WriteLine("Para constr");
            this.IdNo = IdNo;
            this.Name = Name;
        }
        public void SetEmpData(int IdNo, string Name)
        {
            this.IdNo = IdNo;
            this.Name = Name;
            Console.WriteLine("emp details saved");
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine($"id:{IdNo} \t Name:{Name}");
        }
        public override string ToString()
        {
            return $"Id:" +
                $"{IdNo}\tName:{Name}";
        }
    }
    class EmployeeMain
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Console.WriteLine(emp1);
            Employee emp2 = new Employee(1000);
            Console.WriteLine(emp2);
            Employee emp3 = new Employee("Raman");
            Console.WriteLine(emp3);
            Employee emp4 = new Employee(1001, "Govind");
            Console.WriteLine(emp4);

        }
    }
}
