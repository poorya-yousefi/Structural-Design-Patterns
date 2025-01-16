namespace StructuralDesignPatterns.Decorator.Structure;

public class ConcDecorator1 : BaseDecorator
{
    public ConcDecorator1(IComponent wrappee) : base(wrappee)
    {
    }

    public override void Execute()
    {
        Wrappee.Execute();
        Console.WriteLine("ConcDecorator1.Execute()");
    }
}