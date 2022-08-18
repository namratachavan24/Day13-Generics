using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricsExample
{
    public class UC1_Generics<T> 
    {
         private T[] inputArray;

            public UC1_Generics(T[] inputArray)
            {
                this.inputArray = inputArray;
            }
            public void toPrint()
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("___________________");
            }
            public int FindMax(int first, int second, int third)
            {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)     
            {
                Console.WriteLine("first is having max value " + first);
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second is having max value" + second);
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("second is having max value" + third);
                return third;
            }
            else
            {
                Console.WriteLine("ALL VALUES ARE SAME");
                return first;
            }
        }
    }
}
