using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            PrintWelcomeMessage();
            
            while(true){
                PerformOneCalculation();
            }
        }
    

        private static void PrintWelcomeMessage(){
            Console.WriteLine("==========================");
            Console.WriteLine("Welcome to The Calculator");
            Console.WriteLine("==========================");
        }

        private static void PerformOneCalculation(){
            var op = AskForOperator();
            var numbers = AskForAmountOfNumArray(op);
            var answer = CalculateAnswer(op, numbers);

            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
        }

        private static string AskForOperator(){
            Console.Write("Please choose a operator: +, -, *, /: ");
            string op = Console.ReadLine();
            return op;

        }

        private static int[] AskForAmountOfNumArray(string op){
            //declare line to caluclate more than two numbers
           var counter = AskForNumber("How many numbers do you want to " + op + " ? ");
            //created empty array to store numbers
            int [] nums =  new int[counter];
            //for loop to read nums and put into an array
            for (int i = 0; i < counter; i++)
            {
                nums[i] = AskForNumber("Please enter number " + (i  + 1)  +": ");
            }
            return nums;
        }
        
        private static int AskForNumber(string message){
            int count;

            do {
                Console.Write(message);
            } while(!int.TryParse(Console.ReadLine(), out count));
            return count;
        }

        private static int CalculateAnswer(string op, int[] nums){
            int answer = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(op == "+") {
                    answer = answer + nums[i];
                }
                else if (op == "-") {
                    answer = answer - nums[i];
                }

                else if (op == "*") {
                    answer = answer * nums[i];
                }

                else if (op == "/") {
                    answer = answer / nums[i];
                }
            
                else {
                    Console.Write("Invalid operator. Please try again");
                } 
            }
              return answer;
        }
    }
}

        