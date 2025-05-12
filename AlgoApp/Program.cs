using _01NaturalSum;
using _02Factorial;
using _03MultiplicationTable;
using _04EvenNumbers;
using _05NumberSquares;
using _06FibonacciSequence;

namespace AlgoApp;

public class Program
{
    public static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("===== Algorithm Utility Programs =====\n");
            Console.WriteLine("1. Calculate the Sum of Natural Numbers to N");
            Console.WriteLine("2. Calculate the Factorial of a Number");
            Console.WriteLine("3. Print the Multiplication Table of a Number");
            Console.WriteLine("4. Print all Even Numbers from 1 to N");
            Console.WriteLine("5. Print the Squares of Numbers from 1 to 10");
            Console.WriteLine("6. Print the First N Terms of the Fibonacci Sequence");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice (0-6): ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 6.");
                WaitForKeyPress();
                continue;
            }

            switch (choice)
            {
                case 0:
                    exit = true;
                    Console.WriteLine("\nExiting program. Goodbye!");
                    break;

                case 1:
                    CalculateSumOfNaturalNumbers();
                    break;

                case 2:
                    CalculateFactorial();
                    break;

                case 3:
                    PrintMultiplicationTable();
                    break;

                case 4:
                    PrintEvenNumbers();
                    break;

                case 5:
                    PrintNumberSquares();
                    break;

                case 6:
                    PrintFibonacciSequence();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                    WaitForKeyPress();
                    break;
            }
        }
    }

    private static void CalculateSumOfNaturalNumbers()
    {
        Console.Clear();
        Console.WriteLine("===== Sum of Natural Numbers to N =====\n");

        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            WaitForKeyPress();
            return;
        }

        int sum = NaturalNumberCalculator.CalculateSum(n);
        Console.WriteLine($"\nThe sum of first {n} natural numbers is: {sum}");
        WaitForKeyPress();
    }

    private static void CalculateFactorial()
    {
        Console.Clear();
        Console.WriteLine("===== Factorial Calculator =====\n");

        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            WaitForKeyPress();
            return;
        }

        int factorial = FactorialCalculator.Calculate(n);
        Console.WriteLine($"\nThe factorial of {n} is: {factorial}");
        WaitForKeyPress();
    }

    private static void PrintMultiplicationTable()
    {
        Console.Clear();
        Console.WriteLine("===== Multiplication Table =====\n");

        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            WaitForKeyPress();
            return;
        }




        string[] table = MultiplicationTableGenerator.Generate(n);

        Console.WriteLine($"\nMultiplication Table for {n}:\n");
        foreach (string line in table)
        {
            Console.WriteLine(line);
        }
        WaitForKeyPress();
    }

    private static void PrintEvenNumbers()
    {
        Console.Clear();
        Console.WriteLine("===== Even Numbers Printer =====\n");

        Console.Write("Enter the upper limit: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            WaitForKeyPress();
            return;
        }

        int[] evenNumbers = EvenNumberFinder.GetEvenNumbers(n);

        Console.WriteLine($"\nEven numbers from 1 to {n}:\n");
        if (evenNumbers.Length == 0)
        {
            Console.WriteLine("No even numbers in the given range.");
        }
        else
        {
            Console.WriteLine(string.Join(", ", evenNumbers));
        }

        WaitForKeyPress();
    }

    private static void PrintNumberSquares()
    {
        Console.Clear();
        Console.WriteLine("===== Number Squares =====\n");
        var squares = SquareCalculator.CalculateSquares();

        Console.WriteLine("Squares of numbers from 1 to 10:\n");
        foreach (string square in squares)
        {
            Console.WriteLine(square);
        }

        WaitForKeyPress();
    }

    private static void PrintFibonacciSequence()
    {
        Console.Clear();
        Console.WriteLine("===== Fibonacci Sequence =====\n");

        Console.Write("Enter the number of terms: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            WaitForKeyPress();
            return;
        }

        int[] sequence = FibonacciGenerator.GenerateSequence(n);

        Console.WriteLine($"\nFirst {n} terms of the Fibonacci sequence:\n");
        Console.WriteLine(string.Join(", ", sequence));

        WaitForKeyPress();
    }

    private static void WaitForKeyPress()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
    }
}
