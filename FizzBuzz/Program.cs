using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                var output = FizzBuzz.Library.FizzBuzzer.Getvalue(i);

                Console.WriteLine(output);
            }
        }
    }
}
