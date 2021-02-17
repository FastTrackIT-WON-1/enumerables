using System.Collections.Generic;

namespace Enumerables
{
    public static class Fibonacci
    {
        public static IEnumerable<long> Get(int n)
        {
            yield return 0;
            int lastN1 = 0;
            int lastN2 = 1;
            for (int i = 1; i <= n; i++)
            {
                int currentN = lastN1 + lastN2;
                yield return currentN;
                lastN2 = lastN1;
                lastN1 = currentN;
            }
        }
    }
}
