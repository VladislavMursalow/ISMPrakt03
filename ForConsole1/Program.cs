using System;

namespace ForConsole1
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
              
                Console.WriteLine($"Результат: {MultiplyFromAtoB(A, B)}");

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

        static int MultiplyFromAtoB(int A, int B) 
        {
            int result = 1;
            for (int i = A; i <= B; i++) 
            {
                result *= i;
            }
            return result;
        }

    }
}
