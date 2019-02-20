using System;

namespace IntegerLoop
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Print even integers from 0 to 50.
            for (int num = 1; num < 51; num++)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
