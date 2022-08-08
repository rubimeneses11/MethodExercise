using System;

namespace MethodExercise
{
    class Program
    {   //Exercise two//
        public static int sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int multiply(int number3, int number4)
        {
            return number3 * number4;
        }

        static void Main(string[] args)
        {
            var dogCount = sum(2, 6);
            var catCount = multiply(10, 2);

            //Exercise one //
            Console.WriteLine("Hello, What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
        }
    }
}

