using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QuestionOne();
            Console.ReadLine();
        }

        static string QuestionOne()
        {
            int statesVisited = 18;
            string replyCorrect = "You're correct I have visited 18 states";
            string replyWrong = "Sorry Wrong Answer";
            Console.WriteLine("How many states have I visited?");
            string userResponse = Console.ReadLine();
            int formattedUserResponse = int.Parse(userResponse);

            if (formattedUserResponse == statesVisited)
            {
                Console.WriteLine(replyCorrect);
                return replyCorrect;
            }
            else
            {
                Console.WriteLine(replyWrong);
                return replyWrong;
            }
        }
    }
}
