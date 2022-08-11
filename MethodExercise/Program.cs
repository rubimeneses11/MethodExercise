using System;

namespace MethodExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}! Give me a verb.");
            var verb1 = Console.ReadLine();

            Console.WriteLine($"Thanks! Now, can you give me a noun?");
            var noun1 = Console.ReadLine();

            Console.WriteLine("Great! Can you give me another verb?");
            var verb2 = Console.ReadLine();

            Console.WriteLine("Can you give me an adjective?");
            var adjective1 = Console.ReadLine();

            Console.WriteLine("Almost done, Can you give me another adjective?");
            var adjective2 = Console.ReadLine();

            Console.WriteLine("Last one! Give me one more adjective, please.");
            var adjective3 = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is the story you helped me write!");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine($"Every night the coder goes to sleep dreaming about {verb1}." +
                $" When she wakes up she has a cup of {noun1}. She has a {adjective1} computer" +
                $" that gets all her work done. She likes it because it is {adjective2} and {adjective3}." +
                $" Time to {verb2} the world, she says!");
        }
    }
}

