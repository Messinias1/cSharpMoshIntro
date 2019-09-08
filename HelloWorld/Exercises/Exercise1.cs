using System;

namespace HelloWorld.Exercises
{
    public class Exercise1
    {
        // exercise 1
        static void exercise1()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var inputNum = Console.ReadLine();

            if (Int32.Parse(inputNum) > 10 || Int32.Parse(inputNum) < 1)
            {
                Console.WriteLine("Invalid");
            }
            else
                Console.WriteLine("Valid");
        }         
    }
}
