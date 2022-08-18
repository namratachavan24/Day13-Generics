using GenericsExp;

namespace GenricsExample
{
    class Program
    {
        private static int[] inputArray;
        private static float[] floatArray;
        private static string[] stringArray;

        public static void Main(String[] args)
        {
            //UC-1
            Console.WriteLine("\n Find Maximum Value Between 3 Integer Numbers");
            int first = 200, second = 10, third = 20;
            UC1_Generics<int> obj1 = new UC1_Generics<int>(inputArray);
            int val = obj1.FindMax(first, second, third);
            Console.WriteLine(val);

            //UC-2
            Console.WriteLine("\n Find Maximum Value Between 3 Float Numbers");
            float one = 5.1f, two = 5.8f, three = 1.0f;
            FloatMaximumNo<float> obj2 = new FloatMaximumNo<float>(floatArray);
            float value = obj2.FindMaximum(one, two, three);
            Console.WriteLine(value);

            //UC-3
            Console.WriteLine("\n Find Maximum Value Between 3 strings");
            String aOne = "Namrata", bTwo = "Hello", cThree = "Hey";
            UC3_MaxMin<string> obj3 = new UC3_MaxMin<string>(stringArray);
            String val1 = obj3.maxMinString(aOne, bTwo, cThree);
            Console.WriteLine(val1);

            //UC-4
            Console.WriteLine("\n Find maximum value using Array Sorting Method");
            int[] intArr = { 112, 344, 432, 555, 678 };
            int intMax = MimMaxArraySort.MaximumInteger(intArr);
            Console.WriteLine("\n Maximum Value is : "+ intMax);
            Console.WriteLine("*------------------------------*");
            float[] floatArr = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            float floatMax = MimMaxArraySort.MaximumFloat(floatArr);
            Console.WriteLine("\n Maximum Value is :" + floatMax);
            Console.WriteLine("*------------------------------*");
            List<string> stringArr = new List<string> { "Red", "Blue", "Orange", "Green", "Yellow" };
            string stringMax = MimMaxArraySort.MaximumString(stringArr);
            Console.WriteLine(" Maximum Value is :" + stringMax);


            //UC-5
            Console.WriteLine("\nFind maximum value using Generics\n");
            int[] intArray = { 112, 344, 432, 555, 678 };
            MaxInArrayGenerics<int> generic = new MaxInArrayGenerics<int>(intArray);
            generic.PrintMaximumVal();
            Console.WriteLine("\n*------------------------------*");
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            MaxInArrayGenerics<float> genericFloat = new MaxInArrayGenerics<float>(floatArray);
            genericFloat.PrintMaximumVal();
            Console.WriteLine("\n*------------------------------*");
            string[] stringArray = { "Red", "Blue", "Orange", "Green", "Yellow" };
            MaxInArrayGenerics<string> genericString = new MaxInArrayGenerics<string>(stringArray);
            genericString.PrintMaximumVal();


        }
    }
}
