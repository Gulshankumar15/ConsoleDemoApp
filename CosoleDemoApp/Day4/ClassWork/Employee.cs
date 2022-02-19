using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.Day4.ClassWork
{
    internal class Employee
    {
        int IdNo;
        string Name;
        public Employee()
        {
            Console.WriteLine("Default constructor");
            this.IdNo = 1000;
            this.Name = "admin";

        }
        public Employee(int IdNo)
        {
            Console.WriteLine("Parametric constructor");
            this.IdNo= IdNo;

        }
        public Employee(string Name)
        {
            Console.WriteLine("para constr");
            this.Name= Name;

        }
        public Employee(int IdNo,string Name)
        {

        }
        public void SetEmpData(int IdNo,string Name)
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
            emp1.DisplayEmpDetails();

            Employee emp2 = new Employee(); 
            emp2.SetEmpData(1000, "Raja");

            Console.WriteLine(emp2);

            Employee emp3 = emp2;
            emp2.SetEmpData(2000, "Ramesh");
            Console.WriteLine(emp3); //2000 ramesh
            Console.WriteLine(emp2); // 2000 ramesh becaue emp3 copied the reference of emp2



        }
    }
}
