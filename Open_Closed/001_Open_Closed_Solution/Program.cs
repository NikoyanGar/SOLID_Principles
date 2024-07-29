using System.Data;

namespace _001_Open_Closed_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public abstract class FileExporter
    {
        public abstract void Export(string filePath, DataTable data);
    }
    public class CsvFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to a CSV file.
        }
    }
    public class ExcelFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to an Excel file.
        }
    }
    public class JsonFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to a JSON file.
        }
    }
    //Applying the OCP allows for adding new file exporters without modifying old ones,
    //making it easier to add new features by introducing subclasses of the FileExporter base class.

    //Benefits
    //This approach enhances code flexibility, reusability, and maintainability.
    //Your code can seamlessly handle new requirements and changes without introducing bugs or disrupting the existing functionality.
}
