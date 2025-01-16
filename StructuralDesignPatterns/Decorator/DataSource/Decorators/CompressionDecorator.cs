namespace StructuralDesignPatterns.Decorator.DataSource.Decorators;

public class CompressionDecorator : DataSourceBaseDecorator
{
    public CompressionDecorator(IDataSource dataSource) : base(dataSource)
    {
    }

    public override string ReadData()
    {
        DataSource.ReadData();
        Console.WriteLine("Data is decompressed");
        return "Data is decompressed";
    }

    public override void WriteData(string data)
    {
        Console.WriteLine("Data is compressed");
        DataSource.WriteData(data);
    }
}
