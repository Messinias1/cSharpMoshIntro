using HelloWorld.Math;
using HelloWorld.Exercises;
using System.Linq;
using System;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
}
class helloworld
    {
    static void Main(string[] args)
        {

        //  Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

        //for (var i = 0; i < 100; i++)
        //{
        //    if(i%3 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

        //void Exercise2()
        //{
        //    var total = 0;
        //    while (true)
        //    {
        //        Console.WriteLine("Enter a number (or 'ok' to exit): ");
        //        var input = Console.ReadLine();

        //        if (input.ToLower() == "ok")
        //            break;

        //        total += Convert.ToInt32(input);
        //    }
        //    Console.WriteLine("Total of all entered numbers: " + total);
        //}

        //Exercise2();

        // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        //void Exercise3()
        //{
        //    Console.WriteLine("Enter a number");
        //    var input = Convert.ToInt32(Console.ReadLine());

        //    for (var i = input - 1; i >= 1; i--)
        //    {
        //        input = input * i;
        //    }
        //    Console.WriteLine("\nFactorial of Given Number is: " + input);
        //}
        //Exercise3();

        // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

        //        void Exercise4()
        //        {
        //            var random = new Random();
        //            int correctNumber = random.Next(1, 10);
        //            Console.WriteLine(correctNumber);

        //            for (var attempts = 0; attempts < 4; attempts++)
        //            {
        //                Console.WriteLine("Guess a number between 1 and 10: ");
        //                var input = Convert.ToInt32(Console.ReadLine());

        //            if (input == correctNumber)
        //            {
        //                Console.WriteLine("You Won");
        //                    break;
        //            }
        //        }
        //            Console.WriteLine("man guesses exceeded");
        //    }
        //Exercise4();

        //5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers, seperated by a comma");
            var input = Console.ReadLine().Split(',').Take(4);

            int[] digits = input.Select(d => Convert.ToInt32(d)).ToArray();


            Console.WriteLine(digits.Max());
        }
        Exercise5();

        //Console.WriteLine("Enter Speed Limit");
        //var speedLimit = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter Car Speed");
        //var carSpeed = Convert.ToInt32(Console.ReadLine());

        //var demerit = 5;
        //var points = (carSpeed - speedLimit) / demerit;
        //if (carSpeed < speedLimit)
        //{
        //    Console.WriteLine("OK");
        //}
        //else if (carSpeed > speedLimit)
        //{
        //    Console.WriteLine(points);
        //}

        //if (points > 12)
        //{
        //    Console.WriteLine("License Suspended");
        //}

        // Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. landscape = wider portrait = taller

        //Console.WriteLine("Enter image height");
        //var height = Console.ReadLine();

        //Console.WriteLine("Enter image width");
        //var width = Console.ReadLine();

        //if(Int32.Parse(height) > Int32.Parse(width))
        //{
        //    Console.WriteLine("Image is a Portrait");
        //}
        //else if(Int32.Parse(width) > Int32.Parse(height))
        //{
        //    Console.WriteLine("Image is a Landscape");
        //}

        //Console.WriteLine("Enter a number");
        //var input = Console.ReadLine();
        //Console.WriteLine("Enter Another Number");
        //var input2 = Console.ReadLine();



        //if(Int32.Parse(input) > Int32.Parse(input2))
        //{
        //    Console.WriteLine("First number is larger", input);
        //}
        //else if(Int32.Parse(input2) > Int32.Parse(input))
        //{
        //    Console.WriteLine("Second number is larger", input2);
        //}
        //else
        //    Console.WriteLine("Invalid");



        // IF AND SWITCH STATEMENTS

        //int hour = 22;

        //if (hour > 0 && hour < 12)
        //{
        //    Console.WriteLine("It's morning.");
        //}
        //else if (hour >= 12 && hour < 18)
        //{
        //    Console.WriteLine("Afternoon");
        //}
        //else
        //    Console.WriteLine("It's evening");

        //bool isGoldCustomer = true;

        //float price = (isGoldCustomer) ? 19.95f : 29.95f;
        //Console.WriteLine(price);

        //var season = Season.Autumn;

        //switch (season)
        //{
        //    case Season.Spring:
        //        Console.WriteLine("It's Spring");
        //        break;
        //    case Season.Summer:
        //        Console.WriteLine("It's Summer");
        //        break;
        //    case Season.Autumn:
        //        Console.WriteLine("It's Autumn");
        //        break;
        //    case Season.Winter:
        //        Console.WriteLine("It's Winter");
        //        break;
        //    default:
        //        Console.WriteLine("Which season is it?");
        //        break;
        //}

        // VALUE TYPE

        //var a = 10;
        //var b = a;
        //b++;
        //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        // REFERENCE TYPE

        //var array1 = new int[3] { 1, 2, 3 };
        //var array2 = array1;
        //array2[0] = 0;
        //Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        // ENUMS

        //var method = ShippingMethod.Express;
        //Console.WriteLine((int)method);

        //var methodId = 2;
        //Console.WriteLine((ShippingMethod)methodId);

        //Console.WriteLine(method.ToString());

        //var methodName = "Express";
        //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        //Console.WriteLine(shippingMethod);

        // STRINGS
        //            var firstName = "Carl";
        //            var lastName = "Kakisis";

        //            var fullName = firstName + " " + lastName;
        //            var myFullName = string.Format("{0}", fullName);
        //            Console.WriteLine(myFullName);

        //            var names = new string[3] { "Carl", "Bob", "Chris" };
        //            var formattedNames = string.Join(",", names);
        //            Console.WriteLine(formattedNames);

        //            var text = @"Yo
        //Carl
        //Whats Up!";
        //            Console.WriteLine(text);

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
