

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