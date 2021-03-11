using System;

namespace lava1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = InputOutput();
            Console.WriteLine("Введіть операції над дробом: {+, -, *, /}");
            string b = Console.ReadLine();
            Console.WriteLine(Count(result, b));

        }

        static int[] InputOutput()
        {
            Console.WriteLine("Введіть Чисельник першого числа ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть Знаменник першого числа ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть Чисельник другого числа ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть Знаменник другого числа ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            int[] myIntArray = new int[4] { a1, a2, b1, b2 };
            return myIntArray;
        }

        static double Count(int[] number, string arithmetic_operation)
        {
            if (arithmetic_operation == "+")
            {
                double result = (number[0] / number[1]) + (number[2] / number[3]);
                return result;
            }
            else if (arithmetic_operation == "-")
            {
                double result = (number[0] / number[1]) - (number[2] / number[3]);
                return result;
            }
            else if (arithmetic_operation == "*")
            {
                double result = (number[0] / number[1]) * (number[2] / number[3]);
                return result;
            }
            else if (arithmetic_operation == "/")
            {
                double result = (number[0] / number[1]) / (number[2] / number[3]);
                return result;
            }
            return 0;
        }
    }
}