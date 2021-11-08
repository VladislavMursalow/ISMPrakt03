using System;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int inputNum = 0, sum = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine($"Сума: {sum}");
                Console.WriteLine("Вихід з програми - 0");
                inputNum = CorrectIntInput();
                sum += inputNum;

            } while (inputNum != 0);
        }

        static int CorrectIntInput()
        {
            int result = 0;
            Console.Write("Введіть число ");

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Виввели неправильне число! Повторіть ще раз\n ->");
            }
            return result;
        }

       
    }
}
