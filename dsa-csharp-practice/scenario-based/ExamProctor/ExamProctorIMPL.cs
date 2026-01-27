using System;
using System.Collections.Generic;

public class ExamProctorIMPL : IExamProctor
{
    private Stack<int> navigationStack = new Stack<int>();
    private Dictionary<int, string> answers = new Dictionary<int, string>();
    private Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public ExamProctorIMPL()
    {
        // Sample correct answers
        correctAnswers[1] = "A";
        correctAnswers[2] = "B";
        correctAnswers[3] = "C";
        correctAnswers[4] = "D";
        correctAnswers[5] = "A";
    }

    public void VisitQuestion(int questionId)
    {
        navigationStack.Push(questionId);
        Console.WriteLine($"Visited Question {questionId}");
    }

    public void GoBack()
    {
        if (navigationStack.Count == 0)
        {
            Console.WriteLine("No navigation history!");
            return;
        }

        int lastQuestion = navigationStack.Pop();
        Console.WriteLine($"Moved back from Question {lastQuestion}");
    }

    public void AnswerQuestion(int questionId, string answer)
    {
        answers[questionId] = answer;
        Console.WriteLine($"Saved answer for Question {questionId}");
    }

    public void SubmitExam()
    {
        int score = CalculateScore();
        Console.WriteLine($"Final Score: {score}/{correctAnswers.Count}");
    }

    // Function for evaluation
    private int CalculateScore()
    {
        int score = 0;

        foreach (var q in correctAnswers)
        {
            if (answers.ContainsKey(q.Key) && answers[q.Key] == q.Value)
            {
                score++;
            }
        }

        return score;
    }
}
