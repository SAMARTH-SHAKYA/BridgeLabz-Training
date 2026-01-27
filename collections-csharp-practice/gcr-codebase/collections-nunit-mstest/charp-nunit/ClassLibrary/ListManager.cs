using System.Collections.Generic;

namespace TestingProject.csharp_collections.assignment.Nunit
{
    public class ListManager
    {
        public void AddElement(List<int> list, int a) => list.Add(a);
        public void RemoveElement(List<int> list, int a) => list.Remove(a);
        public int GetSize(List<int> list) => list.Count;
    }
}
