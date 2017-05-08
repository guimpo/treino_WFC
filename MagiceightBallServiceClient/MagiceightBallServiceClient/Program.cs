using MagiceightBallServiceClient.ServiceReference1;
using System;

namespace MagiceightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Ask the Magic 8 Ball *****\n");
            using (EightBallClient ball = new EightBallClient())
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine("8-Ball says: {0}", answer);
            }
            Console.ReadLine();
        }
    }
}
