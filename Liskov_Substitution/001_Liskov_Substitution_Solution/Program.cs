namespace _001_Liskov_Substitution_Solution
{
    //To address this violation, we need to ensure the correct substitution of objects.
    //One approach is to introduce an interface called IEnginePowered that represents vehicles with engines.
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnginePowered car = new Car();
            car.StartEngine(); // Outputs "Starting the car engine."

            Vehicle electricCar = new ElectricCar();
            // electricCar.StartEngine(); // This line won't compile because ElectricCar does not implement IEnginePowered
        }
    }
    public abstract class Vehicle
    {
        // Common vehicle behavior and properties.
    }
    public interface IEnginePowered
    {
        void StartEngine();
        void StopEngine();
    }
    public class Car : Vehicle, IEnginePowered
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
            // Code to start the car engine.
        }
        public void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
            // Code to stop the car engine.
        }
    }
    public class ElectricCar : Vehicle
    {
        // Specific behavior for electric cars.
    }
    //We can substitute objects of the Car or ElectricCar class where instances of the IEnginePowered are expected.
    //The ElectricCar class does not need to implement engine-related methods.

    //Benefits
    //Using the LSP, we ensured that the program remained accurate and consistent when substituting objects of derived classes for objects of their base class.
}
