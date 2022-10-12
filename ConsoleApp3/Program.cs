using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2+2=?");
            
            int c = 4;
            int b = Convert.ToInt32(Console.ReadLine());
            if (c == b)
            {
                while (true)
                {
                    Console.WriteLine("z");
                    Console.WriteLine("v");
                }
            }
            else
            {
                Console.WriteLine(":c");
            }
               

        }
    }
}
