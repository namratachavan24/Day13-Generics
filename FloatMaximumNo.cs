using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExp
{
    public class FloatMaximumNo<T>
    {
        private T[] floatArray;

        public FloatMaximumNo(T[] floatArray)
        {
            this.floatArray = floatArray;
        }
        public void toPrintFloat()
        {
            foreach (var element in floatArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("___________________");
        }
        public float FindMaximum(float one, float two, float three)
        {
            if (one.CompareTo(two) > 0 && one.CompareTo(three) > 0)    // >0 means first is greater  
            {
                Console.WriteLine("first is having max value " + one);
                return one;
            }
            else if (two.CompareTo(one) > 0 && two.CompareTo(three) > 0)
            {
                Console.WriteLine("second is having max value" + two);
                return two;
            }
            else if (three.CompareTo(one) > 0 && three.CompareTo(two) > 0)
            {
                Console.WriteLine("second is having max value" + three);
                return three;
            }
            else
            {
                Console.WriteLine("ALL VALUES ARE SAME");
                return one;
            }
        }
    }
}
