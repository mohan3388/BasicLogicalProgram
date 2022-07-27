using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogical
{
    public class Logic
    {
        public static void Calculate()
        {
            int tailCount = 0;
            int headCount = 0;

            double tailPercentage = 0;
            double headPercentage = 0;

            Console.WriteLine("Enter number of Flips: ");
            int Flips = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Flips; i++)
            {
                Random random = new Random();
                int randValue = random.Next(2);
                Console.WriteLine("Random values: " + randValue);
                if (randValue == 0)
                {
                    Console.WriteLine("Tail");
                    tailCount++;
                }
                else if (randValue == 1)
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("No flips");
                }
            }
            headPercentage = (headCount * 100) / Flips;
            tailPercentage = (tailCount * 100) / Flips;

            Console.WriteLine("Percentage of head: " + headPercentage);
            Console.WriteLine("Percentage of tail: " + tailPercentage);

        }
    }
}
