namespace StructuralDesignPatterns.Adapter.DuckDuck;

public class TurkeyAdapter(Turkey turkey) : IDuck
{
    private readonly Turkey _turkey = turkey;

    public void Fly()
    {
        for (int i = 0; i < 7; i++)
        {
            _turkey.Fly();
        }
    }

    public void Quack()
    {
        this._turkey.Gobble();
    }
}
