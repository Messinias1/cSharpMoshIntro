﻿using System;
using HelloWorld.Math;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class helloworld
    {
        static void Main(string[] args)
        {

            int hour = 22;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else
                Console.WriteLine("It's evening");

            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("It's Spring");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter");
                    break;
                default:
                    Console.WriteLine("Which season is it?");
                    break;
            }

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
}
