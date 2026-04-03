using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class DatabaseConnectionTest
    {
        private DatabaseConnection databaseConnection;

        [SetUp]   // Runs before each test
        public void Setup()
        {
            databaseConnection = new DatabaseConnection();
            databaseConnection.Connect();
        }

        [TearDown]   // NUnit version of TestCleanup
        public void CleanUp()
        {
            databaseConnection.DisConnect();
        }

        [Test]
        public void Connection_Test()
        {
            Assert.IsTrue(databaseConnection.IsConnected);
        }
    }
}
