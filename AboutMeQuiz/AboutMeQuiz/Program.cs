using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            QuestionFour();
            QuestionFive();
            Console.ReadLine();
        }

        static string[] QuestionOne()
        {
            string[] states = { "Texas", "Florida", "Georgia", "Kentucky", "Colorado", "Washington", "California",
                "North Carolina", "South Carolina","New Mexico", "Arizona", "Indiana", "Illinois", "Missouri",
                "Louisiana", "Oregon", "California", "Alabama"};

            int statesVisited = 18;
            string replyWrong = "Sorry wrong answer.";
            Console.WriteLine("How many states have I visited?");
            string userResponse = Console.ReadLine();
            int formattedUserResponse = int.Parse(userResponse);

            if (formattedUserResponse == statesVisited)
            {
                Console.WriteLine("Correct I have lived in: ");
                for (int i = 0; i < states.Length; i++)
                {
                    Console.WriteLine(states[i]);
                }
                return states;
            }
            else
            {
                Console.WriteLine(replyWrong + " These are the states: ");
                for (int i = 0; i < states.Length; i++)
                {
                    Console.WriteLine(states[i]);
                }
                return states;
            }
        }

        static string QuestionTwo()
        {
            string answer = "Verily";
            Console.WriteLine("What is my dream place to work at? ");
            string userReply = Console.ReadLine();

            if (userReply == answer)
            {
                Console.WriteLine("Correct Verily is an amazing company!");
                return answer;
            }
            else
            {
                Console.WriteLine(userReply + " is cool, but not my favorite.");
                return userReply;
            }
        }

         static string QuestionThree()
         {
            string answer = "Marine Biologist";
            Console.WriteLine("Do you remember what I said yesterday? What did I wan't to be when I was five?");
            string userReply = Console.ReadLine();

            if (userReply == answer)
            {
                Console.WriteLine(@"Aww, you got it I wanted to be a {0} ", answer);
                return answer;
            }
            else
            {
                Console.WriteLine(@"Nope I wanted to a {0}", answer);
                return answer;
            }
         }

        static bool QuestionFour()
        {
            bool wrongAnswer = false;
            int myAge = 22;
            Console.WriteLine("How old am I? ");
            string userReply = Console.ReadLine();
            int formattedReply = int.Parse(userReply);

            if (formattedReply != myAge)
            {
                Console.WriteLine("Wrong answer");
                return wrongAnswer;
            }
            else
            {
                Console.WriteLine("Awesome great guess!");
                return true; 
            }
        }

        static int QuestionFive()
        {
            int greatGrandmasAge = 87;
            Console.WriteLine("How old is my great grandma?");
            string userReply = Console.ReadLine();

            try
            {
                int formattedReply = int.Parse(userReply);
                if (formattedReply == greatGrandmasAge)
                {
                    Console.WriteLine("Wow you're great at guessing!");
                    return greatGrandmasAge;
                }
                else
                {
                    Console.WriteLine("Wrong Guess");
                }
                Console.WriteLine("Thanks For Playing!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return greatGrandmasAge;
        }

    }
}
