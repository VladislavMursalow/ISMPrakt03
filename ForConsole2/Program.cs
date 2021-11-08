using System;

namespace ForConsole2
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

                Console.WriteLine($"Результат: {MapSumToN(N)}");

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

        static float MapSumToN(int N)
        {
            float result = 0;
            for (float i = 1; i <= N; i++) 
            {
                result += 1 / i;
            }

            return result;
        }
    }
}
