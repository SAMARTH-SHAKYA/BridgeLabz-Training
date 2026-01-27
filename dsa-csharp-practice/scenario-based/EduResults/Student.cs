/// <summary>
/// Represents a student with identification details, district information,
/// and academic score. Provides read-only access to district and score,
/// and overrides ToString() to display student details in a formatted manner.
/// </summary>


class Student
{
    private string StudentId;
    private string StudentName;
    private string StudentDistrict;
    private int StudentScore;

    public Student(string studentId, string studentName, string studentDistrict, int studentScore)
    {
        StudentId = studentId;
        StudentName = studentName;
        StudentDistrict = studentDistrict;
        StudentScore = studentScore;
    }

    public string StudentDistrict1 { get => StudentDistrict; }
    public int StudentScore1 { get => StudentScore; }

    public override string? ToString()
    {
        return $"Name: {StudentName}\nStudent Id: {StudentId}\nDistrict: {StudentDistrict}\nScore: {StudentScore}";
    }
}

