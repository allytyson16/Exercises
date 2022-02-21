using System;

namespace exercise2
{
    class Program
    {
        //Lecture 49: Exercise 2
        /*
         * 
         *  Create a console-based program whose Main() method
            prompts the user for an integer value and, in turn, passes
            the value to a method that squares the number and to
            a method that cubes the number. The Cube() method
            should call the Square() method. The Main() method
            displays the results returned from each of the other methods.
         * 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number -");
            int number = int.Parse(Console.ReadLine());
            int squared = Square(number);
            Console.WriteLine("{0} squared is {1}", number, squared);
            int cubed = Cube(number);
            Console.WriteLine("{0} cubed is {1}", number, cubed);
        }
        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }
        public static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }

    }
}
