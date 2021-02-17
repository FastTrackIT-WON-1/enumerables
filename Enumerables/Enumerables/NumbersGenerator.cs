using System.Collections.Generic;

namespace Enumerables
{
    public static class NumbersGenerator
    {
        public static IEnumerable<int> Next()
        {
            int start = 0;
            while (true)
            {
                yield return start;
                start = start + 1;
            }
        }

        public static IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    yield return n;
                }
            }
        }
    }
}
