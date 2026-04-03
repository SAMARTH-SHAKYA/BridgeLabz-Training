using System;
public class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T candidate)
    {
        resumes.Add(candidate);
    }

    public void DisplayAll()
    {
        foreach (var candidate in resumes)
        {
            candidate.Display();
        }
    }

    public List<T> GetAll()
    {
        return resumes;
    }
}
