using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class FileProcessorTests
    {
        private string file = "test.txt";
        private FileProcessor processor;

        [TestInitialize]
        public void Setup()
        {
            processor = new FileProcessor();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(file))
                File.Delete(file);
        }

        [TestMethod]
        public void File_ReadWrite_Test()
        {
            processor.Write(file, "Hello");
            Assert.AreEqual("Hello", processor.Read(file));
        }

        [TestMethod]
        public void File_NotFound_Test()
        {
            Assert.Throws<FileNotFoundException>(() => processor.Read("missing.txt"));
        }
    }
}
