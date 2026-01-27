using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class FileProcessor
    {
        public void Write(string path, string content) => File.WriteAllText(path, content);
        public string Read(string path) => File.ReadAllText(path);
    }
}
