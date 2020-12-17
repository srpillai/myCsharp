using System;
using System.Collections.Generic;

namespace Quiz
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private int CorrectAnswer { get; set; }

        public MultipleChoice(int pointValue, string text, int correctAnswer, List<string> possibleAnswers): base(pointValue, text)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswers;
            PointValue = 1;
        }

        
        public override void DisplayAnswers()
        {
            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
        }

        public bool IsCorrectAnswer(int possibleAnswer)
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

        public override int GetAnswers()
        {
            Console.WriteLine("What will your answer be? Enter the number of the option you believe is correct. For example, to select the first option, enter 1");
            string userAnswer = Console.ReadLine();
            int result = int.Parse(userAnswer);
            if (IsCorrectAnswer(result))
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
