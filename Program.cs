using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Welcome to The Calculator");
            Console.WriteLine("==========================");
            
            Console.Write("Please choose a operator: +, -, *, /: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            string myFirstNum = Console.ReadLine();
            int myInteger = int.Parse(myFirstNum);
            //int.Parse is a method that converts strings to integers

            Console.WriteLine("Please enter another number: ");
            string mySecondNum = Console.ReadLine();
            int mySecondInteger = int.Parse(mySecondNum);

            // Console.WriteLine(myInteger * mySecondInteger);

            int answer = 0;

            if(op == "+") {
                answer = myInteger + mySecondInteger;
            }
            else if (op == "-") {
                answer = myInteger - mySecondInteger;
            }

            else if (op == "*") {
                answer = myInteger * mySecondInteger;
            }

            else if (op == "/") {
                answer = myInteger / mySecondInteger;
            }

            else {
                Console.Write("Invalid operator. Please try again");
            }

            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
        }
    }

}