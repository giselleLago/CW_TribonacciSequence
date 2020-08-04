using System;

namespace CW_TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            var result = a.Tribonacci(new double[] { 1, 1, 1 }, 10);
            Console.ReadKey();
        }
    }
}
