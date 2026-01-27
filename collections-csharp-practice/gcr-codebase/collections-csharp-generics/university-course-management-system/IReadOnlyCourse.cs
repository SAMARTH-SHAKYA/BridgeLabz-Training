public interface IReadOnlyCourse<out T>
{
    IEnumerable<T> GetCourses();
}
