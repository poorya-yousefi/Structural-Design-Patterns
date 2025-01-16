namespace StructuralDesignPatterns.Decorator.DataSource;

public interface IDataSource
{
    void WriteData(string data);
    string ReadData();
}
