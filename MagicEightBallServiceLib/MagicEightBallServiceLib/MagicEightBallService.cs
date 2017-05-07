using System;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        // Somente para apresentação.
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = { "Future Uncertain", "Yes", "No",
                                 "Hazy", "Ask again later", "Definitely" };            
            // Retorna uma resposta aleatória
            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
