using System;

namespace Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int n in NumbersGenerator.GetEvenNumbers(NumbersGenerator.Next()))
            {
                Console.WriteLine(n);
                Console.Write("Continue(y/n)=");
                string reply = Console.ReadLine();
                if (string.Equals(reply, "n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }

        private static void FibonacciWithIterators()
        {
            foreach (int fibo in Fibonacci.Get(7))
            {
                Console.WriteLine(fibo);
            }
        }

        private static void StringCollectionWithYieldBreak()
        {
            var customStringCollection = new FiveStringElementsCollection("test1", "test2", "test3");
            foreach (var element in customStringCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
