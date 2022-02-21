using System;

namespace exercise_1
{
    class Program
    {
        /*
       *Create a console-based application whose Main() method
        asks the user to input an integer and then calls a method
        named MultiplicationTable(), which displays the
        results of multiplying the integer by each of the numbers
           2 through 10
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer - ");
            int integer = int.Parse(Console.ReadLine());
            MultiplicationTable(integer);

        }
        public static void MultiplicationTable(int number)
        {
            for(int i = 2; i < 11; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0} * {1} = {2}", number, i, answer);
            }


        }

    }
}