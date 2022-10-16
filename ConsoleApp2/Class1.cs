using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace enteringValues
{
    public class Input
    {
        static double first;
        static double second;
        static string act = "";
        public static void Num()
        {
            
            try // checking data type
            {
                Console.WriteLine("Enter first number.");
                first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number.");
                second = Convert.ToDouble(Console.ReadLine());
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("No valid number. Try again!");
                Console.ReadLine();
            }

        }
        public static void Add()
        {
            Console.WriteLine($"Result is - '{first + second}'");
        }
        public static void Mult()
        {
            Console.WriteLine($"Result is - '{first * second}'");
        }
        public static void Sub()
        {
            Console.WriteLine($"Result is - '{first - second}'");
        }
        public static void Div()
        {
            Console.WriteLine($"Result is - '{first / second}'");
        }
        public static void actions() 
        { 
           Console.WriteLine("Choose on of the action: sub, mult, div, add.");
           act = Console.ReadLine();
            switch (act)
            {
                case "sub":
                   Input.Sub();
                    break;
                case "add":
                    Input.Add();
                    break;
                case "div":
                    if (first == 0)
                    {
                        Console.WriteLine("Can`t be divided by 0. Try again!"); //prevent division by 0
                    }
                    Input.Div();
                    break;
                case "mult":
                    Input.Mult();
                    break;
                default:
                    Console.WriteLine("No valid action. Try again!");
                    break;

            }
        }
    }          
}





