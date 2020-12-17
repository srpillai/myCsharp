using System;
namespace Quiz
{
    public class TrueOrFalse : Question
    {
        private bool CorrectAnswer { get; set; }

        public TrueOrFalse(int pointValue, string text, bool correctAnswer) : base(pointValue, text)
        {
            PointValue = 1;
            CorrectAnswer = correctAnswer;
        }

        public bool IsCorrectAnswer(bool possibleAnswer)
        {
            if (possibleAnswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DisplayAnswers()
        {
            Console.WriteLine("True or False");
        }

        public override int GetAnswers()
        {
            Console.WriteLine("What will your answer be? Type 't' for True and 'f' for False");
            string userAnswer = Console.ReadLine();
            if (userAnswer.IndexOf('t') >= 0)
            {
                if (IsCorrectAnswer(true))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (IsCorrectAnswer(false))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
