using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            
            Console.WriteLine("Hello, please enter a value between 2 and 10.");
            input = int.Parse(Console.ReadLine());

            if (input%2 == 1)
            {
                for(int j = 0; j < input-1; j++)
                {
                    int temp = j;
                    temp++;
                    Console.WriteLine(temp + ". You entered an odd number.");
                }     
            }
            
            else
            {
                for (int i = 0; i < input+1; i++)
                {
                    int temp = i;
                    temp++;
                    Console.WriteLine(temp + ". You entered an even number.");
                }
            }
        }
    }
}
