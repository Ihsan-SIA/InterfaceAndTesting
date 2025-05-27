

public interface IStriker
{
    void ScoreGoals();
    void SomeAssists();
    void DefendIfPossible();
}

public class Hojlund : IStriker
{
    public void DefendIfPossible()
    {
        Console.WriteLine("I prevented 3 goals throughout the season");
    }

    public void ScoreGoals()
    {
        Console.WriteLine("I scored 15 goals this season");
    }

    public void SomeAssists()
    {
        Console.WriteLine("I made 5 assists this season");
    }
}
public class Mbappe : IStriker
{
    public void DefendIfPossible()
    {
        Console.WriteLine("I prevented 1 goal this season indirectly");
    }

    public void ScoreGoals()
    {
        Console.WriteLine("I scored 55 goals this season");
        Console.WriteLine("Twelve of them were headers");
        Console.WriteLine("Four free kicks");
    }

    public void SomeAssists()
    {
        Console.WriteLine("I made 20 assists too");
        Console.WriteLine("11 of them went to Vini Jr");
    }
}