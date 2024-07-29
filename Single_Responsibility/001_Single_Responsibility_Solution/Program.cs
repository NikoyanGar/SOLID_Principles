namespace _001_Single_Responsibility_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class UserValidator
    {
        public bool ValidateEmail(string email)
        {
            return false;
            // Validation logic
        }
    }
    public class UserRepository
    {
        public void SaveUser(string username, string email, string password)
        {
            // Database persistence logic
        }
    }

    public class UserCreator
    {
        private readonly UserValidator _validator;
        private readonly UserRepository _repository;
        public UserCreator(UserValidator validator, UserRepository repository)
        {
            _validator = validator;
            _repository = repository;
        }
        public void CreateUser(string username, string email, string password)
        {
            if (!_validator.ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }
            // Business rules
            _repository.SaveUser(username, email, password);
        }
    }
    //UserCreator: Coordinates the user creation process, leveraging the validator and repository classes
    //for their specific responsibilities.

    //Benefits
    //By separating the concerns, we achieve a more maintainable and testable codebase.
    //Each class has a single responsibility, allowing for more straightforward modification and extension in the future.
}
