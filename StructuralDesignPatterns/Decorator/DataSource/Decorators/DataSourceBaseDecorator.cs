namespace StructuralDesignPatterns.Decorator.DataSource.Decorators;

public abstract class DataSourceBaseDecorator(IDataSource dataSource) : IDataSource
{
    protected IDataSource DataSource { get; } = dataSource;

    public abstract string ReadData();
    public abstract void WriteData(string data);
}