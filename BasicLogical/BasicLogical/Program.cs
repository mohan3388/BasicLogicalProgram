using System;

namespace BasicLogical
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter first name: ");
            string username = Console.ReadLine();
            int num = username.Length;
            if (num >= 3 && num <= 5)
            {
                Console.WriteLine("Hello " + username + ", How are you");
            }
            else if (num > 5)
            {
                Console.WriteLine("the username should be greater then 5 char");
            }
            else
            {
                Console.WriteLine("username should be greater than 3 char");
            }



        }
    }
}