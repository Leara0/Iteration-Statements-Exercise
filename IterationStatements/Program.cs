using System.ComponentModel;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please enter your age");
            var num1 = GetNumber();
            Console.WriteLine("Please enter your favorite number");
            var num2 = GetNumber();

            Console.WriteLine("\nHere's a lot of numbers coming at you!");
            PrintNumbers();

            Console.WriteLine("\n\nHere's more numbers. I shortened it by counting by 3s,");
            PrintEveryThirdNumber();

            Console.WriteLine($"\nYour 2 numbers are {(AreNumbersEqual(num1, num2) ? "equal" : "not equal")}");
            bool even = IsEven(num1);
            Console.WriteLine($"Your age is {(even ? "even" : "odd")}");
            Console.WriteLine($"Your favorite number is {(IsEven(num2) ? "even" : "odd")}");

            Console.WriteLine($"Your favorite number is {(IsPositive(num2) ? "" : "not")} positive.");
            Console.WriteLine($"Your are {(CanVote(num1) ? "" : "not ")}old enough to vote");
            Console.WriteLine("\nLet's get some variety up in here! Please give me a new number");
            Console.WriteLine($"Your number is {(IsInRange(GetNumber()) ? "" : "not")} between -10 and 10");

            Console.WriteLine("\nLastly, I'll give you the multiplication table for your old favorite number");
            DisplayMultiplicationTable(num2);

            int GetNumber()
            {
                var num = 0;
                var validInput = false;
                do
                {
                    validInput = int.TryParse(Console.ReadLine(), out num);
                    if (!validInput)
                        Console.WriteLine("Please enter a valid number");
                } while (!validInput);

                return num;
            }
            
            void PrintNumbers()
            {
                for (int i = 1000; i > -1001; i--)
                    Console.Write($"{i}, ");
            }

            void PrintEveryThirdNumber()
            {
                var num = 3;
                do
                {
                    Console.Write($"{num}, ");
                    num += 3;
                } while (num <= 999);
            }

            bool AreNumbersEqual(int num1, int num2)
            {
                return num1 == num2 ? true : false;
            }

            bool IsEven(int number)
            {
                return number % 2 == 0 ? true : false;
            }

            bool IsPositive(int number)
            {
                return number > -1 ? true : false;
            }

            bool CanVote(int age)
            {
                return age > 17 ? true : false;
            }

            bool IsInRange(int number)
            {
                for (int i = -10;
                     i < 11;
                     i++) // the ternary would work quicker here but I wanted to force in more loops
                {
                    if (i == number)
                        return true;
                }

                return false;
            }

            void DisplayMultiplicationTable(int number)
            {
                for (int i = 1; i < 13; i++)
                    Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
    }
}