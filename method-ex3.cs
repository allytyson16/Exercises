using System;

namespace method_ex3
{
    class Program
    {
        /*
         * 
         *  Create a method named Sum() that accepts any number of
            integer parameters and displays their sum. Write a Main()
            method that demonstrates the Sum() method works correctly
            when passed one, three, or five integers, or an array of ten
            integers
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Sum(5);
            Sum(5, 10);
            Sum(5, 10, 15, 20, 25);
            int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Sum(myArray);
        }
        public static void Sum(params int[] myArray )
        {
            int sum = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
