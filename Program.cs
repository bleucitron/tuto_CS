using System;

namespace csharp
{
    class Program
    {
        public static void Main()
        {
            var randomNumber = new Random().Next(1, 10);

            Console.WriteLine("Tente de trouver le nombre auquel je pense entre 1 et 500");
            var input = 0;
            var nb = 0;

            do
            {
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    input = number;

                    if (input > randomNumber)
                    {
                        Console.WriteLine("Trop grand");
                    }
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Trop petit");
                    }
                    else
                    {
                        Console.WriteLine("Youpi, tu as essayé {0} fois.", nb);
                    }
                }
                else
                {
                    Console.WriteLine("Un nombre débilos !");
                }
                nb++;
            } while (input != randomNumber);
        }
    }
}

