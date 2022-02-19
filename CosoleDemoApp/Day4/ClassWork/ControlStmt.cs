using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.Day4.ClassWork
{
    internal class ControlStmt
    {
        static void Main(string[] args)
        {
           /* string weekday;
            Console.WriteLine("Enter any weekday");
            weekday =Console.ReadLine();
            switch (weekday)
            {
                case "Monday":
                    Console.WriteLine("1");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            } */
            int[] arr= new int[] {1,2,3,4,5,6,7};
            Console.WriteLine("Array values are");
            /*
                        foreach (Type identifier in collection - name)
                        {

                        } */
            //Boxing
            // object obj = 20; //implicit
            // int y = (int)obj; // unboxing,explicit
            //foreach (Object item in arr)
            //{
            //    if ((float)item > 5) { Console.WriteLine(item); }
            //    //Console.WriteLine(item);
            //}
            foreach (var item in arr) //var keyword is only for local scope not will used in global scope
                                      //for global scope we use dynamic type.
            {
                if (item > 5) { Console.WriteLine(item); }
                //Console.WriteLine(item);
            }

            foreach (dynamic item in arr) //var keyword is only for local scope not will used in global scope
                                      //for global scope we use dynamic type.
            {
                if (item > 5) { Console.WriteLine(item); }
                //Console.WriteLine(item);
            }
        }

    }
}
