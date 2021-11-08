using System;

namespace WhileConsole1
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

                Console.WriteLine($"Результат: {MapPowToN(N)}");

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

        static int MapPowToN(int N)
        {
            int result = 0;

            int i = 1;
            int degree = N;
            while (i <= N) 
            {
                result += (int)Math.Pow(i, degree);
                i++;
                degree--;
            }

            return result;
        }
    }
}
