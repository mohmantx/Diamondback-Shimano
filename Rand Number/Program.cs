using System;

namespace Rand_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            int userguess = 0;

            while (userguess != randomNumber)
            {
                Console.WriteLine("Guess a Number between 1-100");

                int.TryParse(Console.ReadLine(), out userguess);

                if (userguess != randomNumber)
                {
                    Console.WriteLine("Wrong input, try again!");
                }
                else
                {
                    Console.WriteLine("Great job, you are correct!");
                }
            }
            Console.ReadKey();
        }
    }
}
