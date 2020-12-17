using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int Score { get; set; }
        private int Total { get; set; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            Total = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                Total += questions[i].PointValue;
            }
        }

        public void AddQuestion(Question newQuestion)
        {
            Questions.Add(newQuestion);
            Total += newQuestion.PointValue;
        }

        public void RunQuiz()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].DisplayQuestion();
                Questions[i].DisplayAnswers();
                int pts = Questions[i].GetAnswers();
                UpdateScore(pts);
            }
        }

        public void UpdateScore(int x)
        {
            Score += x;
        }

        public void GradeQuiz()
        {
            Console.WriteLine("You finished the quiz! Your score is: " + Score + "/" + Total);
        }

    }
}
