using System;

namespace Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStringCollection = new CustomStringCollection("test1", "test2");
            foreach (var element in customStringCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
