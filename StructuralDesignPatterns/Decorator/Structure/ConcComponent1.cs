namespace StructuralDesignPatterns.Decorator.Structure;

public class ConcComponent1 : IComponent
{
    public void Execute()
    {
        Console.WriteLine("BaseComponent.Execute()");
    }
}
