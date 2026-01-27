using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }
        public void Connect() => IsConnected = true;
        public void DisConnect() => IsConnected = false;
    }
}
