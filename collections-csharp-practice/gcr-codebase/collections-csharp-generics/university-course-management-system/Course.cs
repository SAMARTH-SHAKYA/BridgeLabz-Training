using System;


public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void DisplayAll()
    {
        foreach (var course in courses)
        {
            course.Display();
        }
    }

    public List<T> GetAllCourses()
    {
        return courses;
    }
}
