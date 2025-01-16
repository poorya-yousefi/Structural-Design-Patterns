namespace StructuralDesignPatterns.Decorator.DataSource.Decorators;

public class EncryptionDecorator : DataSourceBaseDecorator
{
    public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
    {
    }

    public override string ReadData()
    {
        DataSource.ReadData();
        Console.WriteLine("Data is decrypted");
        return "Decrypted data";
    }

    public override void WriteData(string data)
    {
        Console.WriteLine("Data is encrypted");
        DataSource.WriteData(data);
    }
}
