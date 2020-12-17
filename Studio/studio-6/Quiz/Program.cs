using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
			Quiz myQuiz = new Quiz(new List<Question>());

			List<string> possAns1 = new List<string>(){"Garfield", "Salem", "Cheshire", "Tom"};
			List<int> correctAns1 = new List<int>(){2, 3};
			Checkbox newQuestion1 = new Checkbox(2, "Who is the best cat in the world?", possAns1, correctAns1);
			myQuiz.AddQuestion(newQuestion1);

            List<string> possAns2 = new List<string>(){"Doc", "Tillie", "Gizmo", "Benji", "Nala"};
			MultipleChoice newQuestion2 = new MultipleChoice(1, "Who won the Halloween Costume Contest?", 3, possAns2);
			myQuiz.AddQuestion(newQuestion2);

            TrueOrFalse newQuestion3 = new TrueOrFalse(1, "Are all dogs the best?", true);
			myQuiz.AddQuestion(newQuestion3);

			myQuiz.RunQuiz();

			myQuiz.GradeQuiz();
		}
    }
}
