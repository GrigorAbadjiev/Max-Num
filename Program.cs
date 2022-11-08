using System;

namespace maxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read n

            // for loop - read n numbers
                // check if is greater the maxNum
                     // if greater > save new max

            // 3
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n-1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Max number: {max}"); 
            
            

            
            
        }
    }
}
