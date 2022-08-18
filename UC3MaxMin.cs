using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExp
{
    public class UC3_MaxMin<T>
    {   
        public T[] stringArray;

        public UC3_MaxMin(T[] stringArray)
        {
            this.stringArray=stringArray;
        }
        public void printStringVal()
        {
            foreach(var elemets in stringArray)
            {
                Console.WriteLine(elemets);
            }
            Console.WriteLine("___________________");
        }

        public string maxMinString(string aOne, string bTwo, string cThree)
        {
            if (aOne.CompareTo(bTwo) > 0 && aOne.CompareTo(cThree) > 0)
            {
                return aOne;
            }
            else if (bTwo.CompareTo(aOne) > 0 && bTwo.CompareTo(cThree) > 0)
            {
                return bTwo;
            }
            else if (cThree.CompareTo(aOne) > 0 && cThree.CompareTo(bTwo) > 0)
            {
                return cThree;
            }
            else
            {
                throw new Exception("First,second and third are same");
            }
        }
    }
}
