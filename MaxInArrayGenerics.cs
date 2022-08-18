using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExp
{
    public class MaxInArrayGenerics<T> where T : IComparable
    {
        public T[] value;
        public MaxInArrayGenerics(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;

        }
        public T MaximumValue(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[sorted_values.Length - 1];
        }
        public T MaximumMethod()
        {
            var max = MaximumValue(this.value);
            return max;
        }
        public void PrintMaximumVal()
        {
            var max = MaximumValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }

    }
}
