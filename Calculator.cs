using System;

public static class Calculator
{
    public static double? Calculate(int first, int second, string operation)
    {
        public static void Main(string[] args)
        {
            string operation;
            int first, second, result;
            Console.Write("Enter first number: ");
            first = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Choose operation (+,-,*,/,%,=): ");
            operation = Convert.ToString(Console.ReadLine());
        
            switch(operation){
                case '+':
                Console.WriteLine("Result: " + (first+second));
                break;
                case '-':
                Console.WriteLine("Result: " + (first-second));
                break;
                case '*':
                Console.WriteLine("Result: " + (first*second));
                break;
                case '/':
                Console.WriteLine("Result: " + (first/second));
                break;
                case '%':
                Console.WriteLine("Result: " +);
                default:
                Console.WriteLine("Incorrect Operation used. Please try again.");
            }

        return null;
    }
}

