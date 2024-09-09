using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2A_2425_OOPMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello there " + args[0]);
            }
            else
            {
                Console.WriteLine("Hello!");
            }

            baseMethod();
            baseMethod();
            baseMethod();
            baseMethod();
            baseMethod();
            baseMethod();
            baseMethod();
            baseMethod();

            Console.WriteLine(intMethod());

            twoNumSum(7, 5);
            twoNumSumWDef(5,20);

            Console.ReadKey();
        }

        static void baseMethod()
        {
            Console.WriteLine("This is a message from the base method.");
        }

        static int intMethod()
        {
            return 7;
        }

        static void twoNumSum(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void twoNumSumWDef(int a = 5, int b = 5)
        {
            Console.WriteLine(a+b);
        }
    }
}
