using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.day5.classwork
{
    internal class Employee1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Expression body readonly property from c# 6.0 and above
        public string FullName => $"{FirstName}{LastName}";

        static void Main(string[] args)
        {
            Employee1 employee1 = new Employee1() { FirstName = "aliya", LastName = "bhatt" };
            Console.WriteLine(employee1.FullName);
        }
    }
}
