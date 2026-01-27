namespace TestingProject.csharp_collections.assignment.Nunit
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect() => IsConnected = true;
        public void DisConnect() => IsConnected = false;
    }
}
