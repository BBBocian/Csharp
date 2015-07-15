using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that picks a random number from 1-100. The user keeps guessing as long as their guess is wrong, and they've guessed less than 7 times. If their guess is higher than the number, say "Too high" if their guess is lower than the number, say "Too low". When they get it right, the game stops. Or, if they hit seven guesses, the game stops even if they never got it right. 

I am thinking of a number between 1-100. You have 7 guesses:
Guess #1:50
Too high
Guess #2:15
Too low
Guess #3:18
Correct. You won!
 */

namespace Hi_Lo_with_limited_tries
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNum;
            randomNum = 18;

            int numOfTries = 1;
            int guess;
            Console.Write("I am thinking of a number between 1-100. You have 7 guesses:\n");
            //write your code here


            bool condition = true;

            while (condition)
            {
                if (numOfTries <8 )
                {
                    Console.Write("Guess #{0}:", numOfTries);
                    guess = int.Parse(Console.ReadLine());

                    if (guess > randomNum)
                        Console.WriteLine("Too high");
                    else if (guess < randomNum)
                        Console.WriteLine("Too low");
                    else
                    {
                        condition = false;
                        break;
                    }
                    numOfTries += 1;
                }
                else
                    condition = false;

                
            }

            //
            if (numOfTries <=7)
                Console.WriteLine("Correct. You won!");
            else
                Console.WriteLine("Sorry you didn't guess it in 7 tries. You lose.");
            Console.ReadLine();
        }
        
    }
}
