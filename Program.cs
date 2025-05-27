

public class UseInterface
{
    private readonly IStriker _striker;
    public UseInterface(IStriker striker)
    {
        _striker = striker;
    }
    public void PlayerName()
    {

        Console.WriteLine("Player name is {0}", _striker.Name());
    }
}


public interface IStriker
{
    string Name { get; set; }
    void ScoreGoals();
    void SomeAssists();
    void DefendIfPossible();
}
public interface ICaptain
{
    void ManageTeam();
    void TalkToReferee();
}

public class Hojlund : IStriker
{
    public string Name { get; set; } = default!;

    public void DefendIfPossible()
    {
        Console.WriteLine("I prevented 3 goals throughout the season");
        this.Name = "Hojlund";
        Console.WriteLine("My name is {0}", Name);
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
public class Mbappe : IStriker, ICaptain
{
    public void ManageTeam()
    {
        Console.WriteLine("Everybody must be in order");
    }
    public void TalkToReferee()
    {
        Console.WriteLine("Make ref no sha do us ojoro");
    }
    public string Name { get; set; } = default!;
    public void DefendIfPossible()
    {
        Console.WriteLine("I prevented 1 goal this season indirectly");
    }

    public void ScoreGoals()
    {
        this.Name = "Mbappe";
        Console.WriteLine("I scored 55 goals this season");
        Console.WriteLine("Twelve of them were headers");
        Console.WriteLine("Four free kicks");
        Console.WriteLine("My name is fvng {0}", this.Name);
    }

    public void SomeAssists()
    {
        Console.WriteLine("I made 20 assists too");
        Console.WriteLine("11 of them went to Vini Jr");
        Console.WriteLine("Yeah, say my name again {0}, that's right", this.Name);
    }
}