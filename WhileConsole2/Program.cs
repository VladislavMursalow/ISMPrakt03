using System;

namespace WhileConsole2
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

                if (N < 1)
                {
                    Console.WriteLine("Не коректний ввід надих, N < 1!!!\n Повторіть ще раз");
                    continue;
                }

                Console.WriteLine($"Результат: {FindLessDegreeNum(N)}");

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

        static int FindLessDegreeNum(int N)
        {
            int K = 0;

            while ((int)Math.Pow(3, K) < N) K++;

            return K;
        }

    
    }
}
