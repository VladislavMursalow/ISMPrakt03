using System;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            do
            {
                Console.Clear();

                A = CorrectIntInput("A");
                B = CorrectIntInput("B");

                if (A > B)
                {
                    Console.WriteLine("Не коректний ввід надих, A > B!!!\n Повторіть ще раз");
                    continue;
                }

                Console.WriteLine($"Результат: {FindSumOfSqueresFromAtoB(A, B)}");

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

        static int FindSumOfSqueresFromAtoB(int A, int B)
        {
            int result = 0;

            for (int i = A; i <= B; i++)
            {
                result += (int)Math.Pow(i, 2);
            }

            return result;
        }

    }
}
