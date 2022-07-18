using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, answer;
            Console.WriteLine("Hello, please type number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplicate table of the number: " + number);

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(number + "x" + i + "=" + number * i); 
            }
            
        }
    }
}
