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
            int count = 0;
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
               for(int j=1; j<=i; j++)
                {
                    if(i%j==0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
        }
    }
}
