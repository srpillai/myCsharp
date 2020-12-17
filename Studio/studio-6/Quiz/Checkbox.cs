using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Checkbox : Question
    {
        private List<string> PossibleAnswers { get; set; }
        private List<int> CorrectAnswers { get; set; }

        public Checkbox(int pointValue, string text, List<string> possibleAnswers, List<int> correctAnswers) : base(pointValue, text)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
            PointValue = CorrectAnswers.Count;
        }

        public override void DisplayAnswers()
        {
            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
        }

        public int CheckAnswers(List<int> check)
        {
            int answersCorrect = 0;
            for (int i = 0; i < check.Count; i++)
            {
                if (CorrectAnswers.Contains(check[i]))
                {
                    answersCorrect++;
                }
            }
            return answersCorrect;
        }

        public override int GetAnswers()
        {
            List<int> usersAnswers = new List<int>();
            Console.WriteLine("For this question, there are multiple correct answers. To begin answering the question, enter 'y'.");
            string goingToContinue = Console.ReadLine();
            while (goingToContinue.IndexOf('y') >= 0 && usersAnswers.Count <= PossibleAnswers.Count)
            {
                Console.WriteLine("What will your answer be? Enter the number of the option you believe is correct. For example, to select the first option, enter 1");
                string answer = Console.ReadLine();
                int option = int.Parse(answer);
                usersAnswers.Add(option);

                Console.WriteLine("For this question, there are multiple correct answers. To continue answering the question, enter 'y'. To stop, enter 'n'");
                goingToContinue = Console.ReadLine();
            }

            return CheckAnswers(usersAnswers);
        }
    }
}
