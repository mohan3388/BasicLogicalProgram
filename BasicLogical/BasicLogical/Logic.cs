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

            int Quotient = num / 10;
            int Reminder = num % 10;

            Console.WriteLine("Quotient is: "+Quotient);
            Console.WriteLine("Reminder is: "+Reminder);
        }
    }
}
