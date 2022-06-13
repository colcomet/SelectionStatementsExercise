using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        //static Random r = new Random();
        static void Main(string[] args)
        {
            int favNumber = 5; //r.Next(1, 100);

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite school subject?");
            string userFavSubject = Console.ReadLine();
            switch (userFavSubject)
            {
                case "science":
                    Console.WriteLine($"I liked {userFavSubject}, too.");
                    break;
                case "social studies":
                    Console.WriteLine($"Sure, {userFavSubject} is interesting.");
                    break;
                case "gym":
                    Console.WriteLine($"{userFavSubject} is good for keeping active and healthy.");
                    break;
                case "history":
                    Console.WriteLine($"I can't be the only one bored by {userFavSubject}.");
                    break;
                case "math":
                    Console.WriteLine($"Only geeks like us love {userFavSubject}");
                    break;
                default:
                    Console.WriteLine($"I'm not familiar with {userFavSubject}. Does it really exist?");
                    break;
            }

        }
    }
}
