namespace _001_Single_Responsibility
{
    //The Single Responsibility Principle (SRP) promotes clean, maintainable, and scalable software design.
    //It states that a class should change for only one reason, meaning it should have a single responsibility.


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class UserCreator
    {
        public void CreateUser(string username, string email, string password)
        {
            // Validation logic
            if (!ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }
            // Business rules
            // Database persistence
            SaveUserToDatabase(username, email, password);
        }
        private bool ValidateEmail(string email)
        {
            // Validation logic
            return false;
        }
        private void SaveUserToDatabase(string username, string email, string password)
        {
            // Database persistence logic
        }

        //Issue

        //In the previous code, the UserCreator class violates the SRP by combining multiple responsibilities,
        //such as validation and database persistence.
        //This can lead to a tightly coupled class, making it difficult to test and prone to unnecessary modifications.
    }
}
