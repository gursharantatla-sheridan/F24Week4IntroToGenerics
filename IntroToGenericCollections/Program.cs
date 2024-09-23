using System.Collections;

namespace IntroToGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            // GOOD - type safe
            // BAD - static in size

            int[] myArray = new int[4];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;
            myArray[3] = 40;

            //myArray[3] = "hello";
            //myArray[4] = 50;

            int sum = 0;

            for (int i=0; i<myArray.Length; i++)
            {
                int num = myArray[i];
                sum += num;
            }

            Console.WriteLine("Sum = " + sum);



            // ArrayList
            // GOOD - dynamic in size
            // BAD - boxing / unboxing - performance issue - runtime exceptions
            // BAD - not type-safe
            // DO NOT USE IT

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add(20);
            myArrayList.Add(30);
            myArrayList.Add(40);

            //myArrayList.Add("hello");

            sum = 0;

            for (int i=0; i<myArrayList.Count; i++)
            {
                int num = (int)myArrayList[i];
                sum += num;
            }

            Console.WriteLine("\nSum = " + sum);


            // List
            // GOOD - dynamic in size
            // GOOD - type safe
            // GOOD - better in performance - no boxing / unboxing

            List<int> myList = new List<int>(3);
            //Console.WriteLine(myList.Capacity);
            myList.Add(10);
            //Console.WriteLine(myList.Capacity);

            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            Console.WriteLine(myList.Capacity);

            myList.Add(40);

            //myList.Add("hello");

            sum = 0;

            for (int i=0; i<myList.Count; i++)
            {
                int num = myList[i];
                sum += num;
            }

            Console.WriteLine("\nSum = " + sum);
        }
    }
}
