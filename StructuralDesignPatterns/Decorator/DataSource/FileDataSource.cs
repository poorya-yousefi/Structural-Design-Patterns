namespace StructuralDesignPatterns.Decorator.DataSource;

public class FileDataSource(string fileName) : IDataSource
{
    public string ReadData()
    {
        Console.WriteLine($"Reading data from file {fileName}");
        return "Some data";
    }

    public void WriteData(string data)
    {
        Console.WriteLine($"Writing '{data}' to file {fileName}");
    }
}
