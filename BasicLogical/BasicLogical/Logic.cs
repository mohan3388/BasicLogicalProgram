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
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine("2" + " ^ " + i + " = " + power);
            }

        }
    }
}
