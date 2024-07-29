namespace _001_Liskov_Substitution
{
    //The Liskov Substitution Principle (LSP) is a concept that guarantees the smooth substitution
    //of objects of derived classes for objects of their base classes.
    //Its fundamental rule asserts that objects of the base class must be interchangeable with objects of any of its derived classes,
    //without impacting the accuracy of the program.
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            car.StartEngine(); // Outputs "Starting the car engine."
            Vehicle electricCar = new ElectricCar();
            electricCar.StartEngine(); // Throws InvalidOperationException
        }
    }
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
            // Code to start the car engine
        }
        public override void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
            // Code to stop the car engine
        }
    }
    public class ElectricCar : Vehicle
    {
        public override void StartEngine()
        {
            throw new InvalidOperationException("Electric cars do not have engines.");
        }
        public override void StopEngine()
        {
            throw new InvalidOperationException("Electric cars do not have engines.");
        }
    }

    //Issue
    //In this example, we have a Vehicle class that represents a generic vehicle.
    //It has abstract methods, StartEngine() and StopEngine(), for starting and stopping the engine.
    //We also have a Car class that inherits from Vehicle and provides the necessary implementation for the engine-related methods.

    //However, when we introduce a new ElectricCar class that does not have an engine,
}
