public interface IExamProctor
{
    void VisitQuestion(int questionId);
    void GoBack();
    void AnswerQuestion(int questionId, string answer);
    void SubmitExam();
}
