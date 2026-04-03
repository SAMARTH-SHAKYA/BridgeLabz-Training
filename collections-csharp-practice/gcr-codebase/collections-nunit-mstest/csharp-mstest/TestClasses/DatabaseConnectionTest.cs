using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class DatabaseConnectionTest
    {
        private DatabaseConnection databaseConnection;

        [TestInitialize]
        public void Setup()
        {
            databaseConnection = new DatabaseConnection();
            databaseConnection.Connect();
        }

        [TestCleanup]
        public void CleanUp()
        {
            databaseConnection.DisConnect();
        }

        [TestMethod]
        public void Connection_Test()
        {
            Assert.IsTrue(databaseConnection.IsConnected);
        }

    }
}
