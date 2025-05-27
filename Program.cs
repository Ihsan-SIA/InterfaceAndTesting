

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
        throw new NotImplementedException();
    }

    public void SomeAssists()
    {
        throw new NotImplementedException();
    }
}