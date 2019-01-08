using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionOne();
            QuestionTwo();
            Console.ReadLine();
        }

        static int QuestionOne()
        {
            int statesVisited = 18;
            string replyCorrect = "You're correct I have visited 18 states";
            string replyWrong = "Sorry wrong answer";
            Console.WriteLine("How many states have I visited?");
            string userResponse = Console.ReadLine();
            int formattedUserResponse = int.Parse(userResponse);

            if (formattedUserResponse == statesVisited)
            {
                Console.WriteLine(replyCorrect);
                return statesVisited;
            }
            else
            {
                Console.WriteLine(replyWrong);
                return formattedUserResponse;
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
                Console.WriteLine(userReply + " is cool but not my favorite");
                return userReply;
            }
        }
    }
}
