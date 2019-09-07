using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class helloworld
    {
        static void Main(string[] args)
        {
            // STRINGS
            var firstName = "Carl";
            var lastName = "Kakisis";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("{0}", fullName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "Carl", "Bob", "Chris" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Yo
Carl
Whats Up!";
            Console.WriteLine(text);

            // ARRAYS

            //var numbers = new int[3];
            //numbers[0] = 1;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;
            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "jack", "jill", "mary" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name.ToString());
            //}

            //var john = new Person();

            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            // VARIABLE TYPES

            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Carl";
            //bool isWorking = true;

            // var KEYWORD

            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "Carl";
            //var isWorking = true;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            // PLACEHOLDERS AND VALUES

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // const KEYWORD

            //const float Pi = 3.14f;

            // IMPLICIT DECLARATION

            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            // EXPLICIT DECLARATION (can cause overflow)

            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            // TYPE CONVERSION

            //var number = "1234";
            //var number2 = "2";
            //int i = Convert.ToInt32(number);
            //int j = Convert.ToInt32(number2);
            //Console.WriteLine(i * j);

            // UNSUCCESSFUL CONVERSION USING A TRY

            //try
            //{
            //    var num = "1234";
            //    byte b = Convert.ToByte(num);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte");
            //
        }
    }
}
