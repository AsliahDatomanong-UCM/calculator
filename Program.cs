public class Program
{
    public static void Main()
    {
        bool running = true;
        
        while (running)
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            
            string operation;
            
            while (true)
            {
                Console.Write("Choose operation (+, -, *, /, %, =): ");
                operation = Console.ReadLine();
                
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%" || operation == "=")
                {
                    break;
                }else{
                    Console.WriteLine("Incorrect operation used, please try again");
                }
            }
            
            if (operation == "=")
            {
                Console.WriteLine("Program terminated.");
                running = false;
                break;
            }

            double? result = Calculator.Calculate(first, second, operation);

            if (result.HasValue)
            {
                Console.WriteLine("Result: " + result.Value);
            }
            
            Console.WriteLine();
        }
    }
}﻿//write your console display in here
