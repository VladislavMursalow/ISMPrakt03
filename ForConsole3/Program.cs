using System;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            float A;
            do
            {
                Console.Clear();

                A = CorrectFloatInput("A");
                N = CorrectIntInput("N");

                if (N < 0)
                {
                    Console.WriteLine("Не коректний ввід надих, N < 0!!!\n Повторіть ще раз");
                    continue;
                }

                Console.WriteLine($"Результат: {PowToN(A, N)}");

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
        static float CorrectFloatInput(string nameOfVariable)
        {
            float result = 0;
            Console.Write("Введіть число " + nameOfVariable + ": ");

            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Виввели неправильне число " + nameOfVariable + "! Повторіть ще раз\n ->");
            }
            return result;
        }

        static float PowToN(float A, int N)
        {
            float result = 1;
            for (float i = 1; i <= N; i++)
            {
                result *= A;
            }
            return result;
        }
    }
}
