using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerables
{
    public class FiveStringElementsCollection : IEnumerable<string>
    {
        private readonly string element1, element2, element3, element4, element5;

        public FiveStringElementsCollection(
            string element1 = "",
            string element2 = "",
            string element3 = "",
            string element4 = "",
            string element5 = "")
        {
            this.element1 = element1 ?? string.Empty;
            this.element2 = element2 ?? string.Empty;
            this.element3 = element3 ?? string.Empty;
            this.element4 = element4 ?? string.Empty;
            this.element5 = element5 ?? string.Empty;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return GetGenericEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetGenericEnumerator();
        }

        private IEnumerator<string> GetGenericEnumerator()
        {
            Console.WriteLine("Preparing to return element1");
            if (string.IsNullOrEmpty(this.element1))
            {
                yield break;
            }
            else
            {
                yield return this.element1;
            }
            Console.WriteLine("After returning element1");

            Console.WriteLine("Preparing to return element2");
            if (string.IsNullOrEmpty(this.element2))
            {
                yield break;
            }
            else
            {
                yield return this.element2;
            }
            Console.WriteLine("After returning element2");

            Console.WriteLine("Preparing to return element3");
            if (string.IsNullOrEmpty(this.element3))
            {
                yield break;
            }
            else
            {
                yield return this.element3;
            }
            Console.WriteLine("After returning element3");

            Console.WriteLine("Preparing to return element4");
            if (string.IsNullOrEmpty(this.element4))
            {
                yield break;
            }
            else
            {
                yield return this.element4;
            }
            Console.WriteLine("After returning element4");

            Console.WriteLine("Preparing to return element5");
            if (string.IsNullOrEmpty(this.element5))
            {
                yield break;
            }
            else
            {
                yield return this.element5;
            }
            Console.WriteLine("After returning element5");
        }
    }
}
