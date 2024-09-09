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

            int numSample = getStringOutInt("Input a number please.");
            Console.WriteLine($"Number is {numSample}");

            Console.WriteLine($"Number is {getStringOutInt("Input a number please.")}");

            int a = getStringOutInt("Input the first number please.");
            int b = getStringOutInt("Input the second number please.");
            Console.WriteLine($"The sum of {a} and {b} is {sumTwoNum(a,b)}");

            Console.WriteLine($"The sum of the two numbers is " +
                $"{sumTwoNum(getStringOutInt("Input the first number please."), getStringOutInt("Input the second number please."))}");

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

        /// <summary>
        /// This method gets an input from the user and changes it to an int.
        /// Hi Seal!
        /// </summary>
        /// <param name="question">The guide question for the user</param>
        /// <returns>Returns an integer</returns>
        static int getStringOutInt(string question)
        {
            string uInput = "";
            int num = 0;

            while (true)
            {
                Console.Write(question);
                uInput = Console.ReadLine();

                try
                {
                    num = int.Parse(uInput);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input not valid, please try again.");
                }
            }

            return num;
        }

        static int sumTwoNum(int a, int b)
        {
            return a + b;
        }
    }
}
