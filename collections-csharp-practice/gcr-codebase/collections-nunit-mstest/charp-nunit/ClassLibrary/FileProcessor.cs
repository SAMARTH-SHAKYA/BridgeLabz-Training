using System.IO;

namespace TestingProject.csharp_collections.assignment.Nunit
{
    public class FileProcessor
    {
        public void Write(string path, string content) => File.WriteAllText(path, content);
        public string Read(string path) => File.ReadAllText(path);
    }
}
