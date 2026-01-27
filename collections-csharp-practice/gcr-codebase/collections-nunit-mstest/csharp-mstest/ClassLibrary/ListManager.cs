using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class ListManager
    {
        public void AddElement(List<int> list, int a) => list.Add(a);
        public void RemoveElement(List<int> list, int a) => list.Remove(a);
        public int GetSize(List<int> list) => list.Count;
    }
}
