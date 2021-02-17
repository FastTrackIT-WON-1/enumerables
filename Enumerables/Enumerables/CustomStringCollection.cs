using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerables
{
    public class CustomStringCollection : IEnumerable<string>
    {
        private readonly string[] elements;

        public CustomStringCollection(params string[] elements)
        {
            this.elements = elements ?? new string[0];
        }

        public IEnumerator<string> GetEnumerator()
        {
            return ((IEnumerable<string>)elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
