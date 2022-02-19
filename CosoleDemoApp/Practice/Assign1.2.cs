using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.Practice
{
    internal class Assign1
    {
        public static int NextPrime(int num)
        { 
            int c=0;
            for(int i=2;i<num/2;i++)
            {
                if(num%i==0)
                {
                    c = num;
                    Console.WriteLine(c);
                    Console.WriteLine($"not prime:{c}");
                    break;
                }
                else
                {
                    Console.WriteLine($"prime prime:{num}");
                    break;
                }
            }
           // Console.WriteLine($"prime prime:{num}");
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any value:");
            int x=Int32.Parse(Console.ReadLine());
            NextPrime(x);
        }
    }
}
