/// <summary>
/// Represents the result data of a district by storing the district name and
/// an array of students. Provides access to the student list and the total
/// number of students in the district.
/// </summary>


class DistrictResult
{
    private string DistrictName;
    private Student[] Students;


    public DistrictResult(string districtName, Student[] students)
    {
        DistrictName = districtName;
        Students = students;
    }

    public Student[] Students1 { get => Students; }

    public int Size()
    {
        return Students.Length;
    }
}

