using System;

namespace PracticeCode
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] rps = new string[] { "rock", "paper", "scissor" };

            Random rand = new Random();

            string randomRps;
            int randNum;

            randNum = rand.Next(0, 3);

            randomRps = rps[randNum];


            do
            {
                Console.WriteLine("Please select Rock,Paper,Scissor or Press any key to quit");
                string userInput = Console.ReadLine().ToLower();
                if (userInput.Equals("rock") || userInput.Equals("paper") || userInput.Equals("scissor"))
                {
                    rpsConditions(userInput, randomRps);
                    continue;
                }
                if (userInput.Equals(""))
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }



            } while (true);

            void rpsConditions(String userInput, String randomRps)
            {
                if (userInput.Equals(randomRps))
                {
                    Console.WriteLine("Tie");
                }
                else if (userInput.Equals("rock") && randomRps.Equals("paper") || (userInput.Equals("scissor") && randomRps.Equals("rock")) || (userInput.Equals("paper") && randomRps.Equals("scissor")))
                {
                    cpuWin(randomRps, userInput);
                }
                else if (userInput.Equals("paper") && randomRps.Equals("rock") || (userInput.Equals("rock") && randomRps.Equals("scissor")) || (userInput.Equals("scissors") && randomRps.Equals("rock")))
                {
                    humanWin(userInput, randomRps);
                }
            }


            void cpuWin(String randomRps, String userInput)
            {
                Console.WriteLine("You picked {0}", char.ToUpper(userInput[0]) + userInput.Substring(1));
                Console.WriteLine("The computer picked {0}", char.ToUpper(randomRps[0]) + randomRps.Substring(1) + " the computer wins");
            }

            void humanWin(String userInput, String randomRps)
            {
                Console.WriteLine("The computer picked {0} ", char.ToUpper(randomRps[0]) + randomRps.Substring(1));
                Console.WriteLine("You picked {0}", char.ToUpper(userInput[0]) + userInput.Substring(1) + " you win");
            }


        }
    }
}