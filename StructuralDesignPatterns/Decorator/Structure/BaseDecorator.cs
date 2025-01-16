namespace StructuralDesignPatterns.Decorator.Structure;

public abstract class BaseDecorator(IComponent wrappee) : IComponent
{
    protected IComponent Wrappee {get;} = wrappee;
    public abstract void Execute();
}
