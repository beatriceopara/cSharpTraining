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

            //declare line to caluclate more than two numbers
            Console.Write("How many numbers do you want to " + op + " ? ");
            int counter = int.Parse(Console.ReadLine());

            //created empty array to store numbers
            int [] nums =  new int[counter];
            //for loop to read nums and put into an array
            for (int i = 0; i < counter; i++)
            {
                Console.Write("Please enter number " + (i  + 1)  +": ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            
            // Console.Write("Enter a number: ");
            // string myFirstNum = Console.ReadLine();
            // int myInteger = int.Parse(myFirstNum);
            // //int.Parse is a method that converts strings to integers

            // Console.WriteLine("Please enter another number: ");
            // string mySecondNum = Console.ReadLine();
            // int mySecondInteger = int.Parse(mySecondNum);

            // Console.WriteLine(myInteger * mySecondInteger);

            //for loop to go through nums and calculate them altogether

            int answer = nums[0];

            for (int i = 1; i < counter; i++)
            {
                if(op == "+") {
                    answer = answer + answer;
                }
                else if (op == "-") {
                    answer = answer - answer;
                }

                else if (op == "*") {
                    answer = answer * answer;
                }

                else if (op == "/") {
                    answer = answer / answer;
                }

                else {
                    Console.Write("Invalid operator. Please try again");
                } 

            }

            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
        }
    }

}