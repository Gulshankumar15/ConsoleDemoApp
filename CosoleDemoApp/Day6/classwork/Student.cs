using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.Day6.classwork
{
    internal class Student
    {
        int _RollNo;
        string _Name;
        int _Age;

        public int RollNo
        {
            get {
                //some logic
                return _RollNo; //to read data
            }
            set { 
                //some logic
                _RollNo = value; //to write data
            }
        }
        public string Name
        {
            get
            {
                //some logic
                return _Name; //to read data
            }
            set
            {
                //some logic
                _Name = value; //to write data
            }
        }
        public int Age
        {
            get
            {
                //some logic
                return _Age; //to read data
            }
            set
            {
                //some logic
                _Age = value; //to write data
            }
        }
        public override string ToString()
        {
            return $"Roll:{_RollNo}\tName:{_Name}\tAge:{_Age}";
        }
    }
    class StudentMain
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "pankaj";
            student.Age = 24;
            student.RollNo = 1000; //write operation ,set accessor will be called

           // Console.WriteLine(student.ToString());
          Console.WriteLine($"{student.RollNo}\t{student.Name}\t{student.Age}");
            Student student1 = new Student()
            {
                Name = "Ranu",
                RollNo = 2000,
                Age = 24

            };

        }
    }
}
