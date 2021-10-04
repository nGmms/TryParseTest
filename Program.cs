using System;

namespace TryParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string numInput = Console.ReadLine();

            int num = 0;
            bool success = Int32.TryParse(numInput, out num);

            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Incorrect Value Entered");
            }
        }
    }
}
