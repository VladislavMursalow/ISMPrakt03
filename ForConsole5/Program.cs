using System;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Clear();

                N = CorrectIntInput("N");

                if (N < 0)
                {
                    Console.WriteLine("Не коректний ввід надих, N < 0!!!\n Повторіть ще раз");
                    continue;
                }

                Console.WriteLine($"Результат: {MapFactorialSummToN(N)}");

                Console.WriteLine("Вийти з програми? -> escape");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static int CorrectIntInput(string nameOfVariable)
        {
            int result = 0;
            Console.Write("Введіть число " + nameOfVariable + ": ");

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Виввели неправильне число " + nameOfVariable + "! Повторіть ще раз\n ->");
            }
            return result;
        }

        static int MapFactorialSummToN(int N)
        {
            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += FindFactiorial(i);
            }

            return result;
        }

        static int FindFactiorial(int num) 
        {
            int result = 1;
            for (int i = 1; i <= num; i++) 
            {
                result *= i;
            }
            return result;
        }
    }
}
