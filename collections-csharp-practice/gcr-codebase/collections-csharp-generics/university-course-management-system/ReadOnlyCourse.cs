using System;

public class ReadOnlyCourse<T> : IReadOnlyCourse<T> where T : CourseType
{
    private List<T> courses;

    public ReadOnlyCourse(List<T> courses)
    {
        this.courses = courses;
    }

    public IEnumerable<T> GetCourses()
    {
        return courses;
    }
}
