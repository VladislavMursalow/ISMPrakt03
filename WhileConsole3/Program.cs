using System;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            float P;
            float startDistance = 10;
            do
            {
                Console.Clear();

                P = CorrectFloatInput("P");

                if (P <= 0)
                {
                    Console.WriteLine("Не коректний ввід надих, Відсоток P не може бути від'ємним або == 0!!!" +
                        "\n Повторіть ще раз");
                    continue;
                }

                if (P > 1)
                {
                    Console.WriteLine("Не коректний ввід надих, Відсоток P не може більше одиниці!!!" +
                        "\n Повторіть ще раз");
                    continue;
                }
                int days;
                float S = FindTaskParameters(P, 10, out days);
                Console.WriteLine($"Результати:\n " +
                    $"День, після якого дня сумарний пробіг лижника за усі дні перебільшить 200: {days}");
                Console.WriteLine($"сумарний пробіг S: {S} км");

                Console.WriteLine("Вийти з програми? -> escape");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
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

        static float FindTaskParameters(float P, float StartDistance, out int days)
        {
            float S = StartDistance;
            int countDays = 1;
            while (S < 200) 
            {
                S += S * P;
                countDays++;
            }

            days = countDays;
            return S;
        }

    }
}
