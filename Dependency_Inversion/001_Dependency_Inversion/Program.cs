namespace _001_Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class UserController
    {
        private MySqlDatabase database;
        public UserController()
        {
            this.database = new MySqlDatabase();
        }

    }
    //Issue
    //In the previous example, the UserController tightly couples with the concrete Database class, creating a direct dependency.
    //If we decide to alter the database implementation or introduce a new storage mechanism,
    //we will need to modify the UserController class, which violates the Open-Closed Principle.
}
