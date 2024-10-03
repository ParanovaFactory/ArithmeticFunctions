using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            double num2 = 54.89273;
            int num3 = -234;
            int result;
            Console.WriteLine(num1);
            Console.WriteLine(++num1);
            Console.WriteLine(--num1);
            Console.WriteLine(Math.Sqrt(num1));
            Console.WriteLine(Math.Floor(num2));
            Console.WriteLine(Math.Ceiling(num2));
            Console.WriteLine(Math.Pow(num1,2));
            Console.WriteLine(Math.Min(num1,num3));
            Console.WriteLine(Math.Max(num1,num3));
            Console.WriteLine(Math.Round(num2));
            Console.WriteLine(Math.Abs(num3));                      //abstract
            Console.WriteLine(Math.Log10(num1));                    //logarithm
            Console.WriteLine(Math.DivRem(num3, num1, out result)); //division
            Console.WriteLine(Math.BigMul(num1,num3));              //multiplation
            
        }
    }
}
