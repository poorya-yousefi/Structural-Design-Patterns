using StructuralDesignPatterns.Decorator.DataSource.Decorators;

namespace StructuralDesignPatterns.Decorator.DataSource;

public static class Test
{
    const bool enableEncryption = true;
    const bool enableDecompression = true;

    public static void Run()
    {
        IDataSource dataSource = new FileDataSource("file.txt");

        if (enableEncryption)
        {
            dataSource = new EncryptionDecorator(dataSource);
        }
        if (enableDecompression)
        {
            dataSource = new CompressionDecorator(dataSource);
        }

        dataSource.ReadData();
        dataSource.WriteData("Hello World!");
    }
}
