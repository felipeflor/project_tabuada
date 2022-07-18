using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, answer;

            do
            {
                Console.WriteLine("Hello, please type number: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Multiplicate table of the number: " + number);

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(number + "x" + i + "=" + number * i);
                }
                Console.WriteLine("Do you want to recalculate? 1 to continue ou 2");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (answer == 1);
            
        }
    }
}
