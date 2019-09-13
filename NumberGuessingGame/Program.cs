using System;

namespace NumberGuessingGame
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a number guessing game! The higher your score, the worse you did!");

            int max = GetIntegerFromUser("What's the maximum range of numbers you are willing to guess from?");

            Console.WriteLine($"Awesome! You have chosen {max} as your maximum range of numbers to guess from");

            Random random = new Random();

            int randomNumber = random.Next(0, max);

            Console.WriteLine($"Now, Lets get started. Pick a number between 0 and {max} ");

            int userResponse1;

            int score = 0;

            do
            {
                userResponse1 = GetIntegerFromUser("What is your guess?");
                if(userResponse1 == randomNumber)
                {
                    Console.WriteLine("CONGRADULATIONS! You have guessed the correct number!");

                    Console.WriteLine($"ThankYou for playing a Number Guessing Game Made by Harrison Rodriguez. Your final score is {score}");
                }
                if (userResponse1 < randomNumber) 
                {
                    Console.WriteLine("Almost, try guessing a number higher then that");
                }
                else
                {
                    score++;
                }
                if (userResponse1 > randomNumber)
                {
                    Console.WriteLine("Almost, try guessing a number lower then that");
                }
                else
                {
                    score++;
                }

            } while (userResponse1 != randomNumber);

            
                


        }



















    }











}
