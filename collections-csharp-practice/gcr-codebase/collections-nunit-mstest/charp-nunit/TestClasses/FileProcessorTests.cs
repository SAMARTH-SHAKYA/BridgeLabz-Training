using NUnit.Framework;
using System.IO;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class FileProcessorTests
    {
        private FileProcessor processor;
        private string filePath;

        [SetUp]
        public void Setup()
        {
            processor = new FileProcessor();
            filePath = "testfile.txt";
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        [Test]
        public void Write_And_Read_File_Test()
        {
            processor.Write(filePath, "Hello NUnit");
            string content = processor.Read(filePath);

            Assert.AreEqual("Hello NUnit", content);
        }
    }
}
