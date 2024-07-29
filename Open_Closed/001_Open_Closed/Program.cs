using System.Data;

namespace _001_Open_Closed
{
    //The Open-Closed Principle (OCP) says that software entities should be open for extension but closed for modification.
    //It allows for adding new functionality without modifying existing code.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class FileExporter
    {
        public void ExportToCsv(string filePath, DataTable data)
        {
            // Code to export data to a CSV file.
        }
    }
    //Issue
    //In this example, the FileExporter class directly implements the functionality for exporting data to CSV files.
    //However, if we later want to support exporting data to other file formats like Excel or JSON,
    //modifying the FileExporter class would violate the OCP.
}
