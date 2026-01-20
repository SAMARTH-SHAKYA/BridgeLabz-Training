using System;

public class ExamMenu
{
    private IExamProctor proctor;

    public ExamMenu()
    {
        proctor = new ExamProctorIMPL();
    }

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Exam Proctor System ---");
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Go Back");
            Console.WriteLine("3. Answer Question");
            Console.WriteLine("4. Submit Exam");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Question ID: ");
                    proctor.VisitQuestion(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    proctor.GoBack();
                    break;

                case 3:
                    Console.Write("Enter Question ID: ");
                    int qid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Answer: ");
                    string ans = Console.ReadLine();
                    proctor.AnswerQuestion(qid, ans);
                    break;

                case 4:
                    proctor.SubmitExam();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
