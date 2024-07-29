namespace _002_Dependency_Inversion
{
    //To address this issue and adhere to the DIP,
    //we must invert the dependencies by introducing an abstraction that both high-level and low-level modules depend on.
    //Typically, this abstraction is defined using an interface or an abstract class.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class UserController
    {
        private IDataStorage dataStorage;
        public UserController(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }
        // ...
    }
    public interface IDataStorage
    {
        // Define the contract for data storage operations.
        void SaveData(string data);
        string RetrieveData();
    }
    public class MySqlDatabase : IDataStorage
    {
        public void SaveData(string data)
        {
            // Implementation for saving data to a database.
        }
        public string RetrieveData()
        {
            return null;
            // Implementation for retrieving data from a database.
        }
    }
    public class MyPgDatabase : IDataStorage
    {
        public void SaveData(string data)
        {
            // Implementation for saving data to a database.
        }
        public string RetrieveData()
        {
            return null;
            // Implementation for retrieving data from a database.
        }
    }
    //Benefits
    //By applying the DIP, we achieve a more flexible and modular design,
    //enabling us to evolve and adapt our systems more easily over time.

}
