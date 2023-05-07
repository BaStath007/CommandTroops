namespace CommandTroops.Models;

/// <summary>
/// 
/// This is the Receiver class, that is responsible for
/// actually implementing ("executing") the different commands.
/// 
/// </summary>
public class Infantry : ITroop
{
    public string SquadName { get; set; }
    public float Direction { get; set; } = 90f;
    public int Speed { get; set; } = 0;

    public Infantry(string squadName)
    {
        SquadName = squadName;
        //Direction = 90;
        //Speed = 0;
    }

    public void Halt()
    {
        Console.WriteLine($"{this.SquadName} has stoped marching.");
        Speed = 0;
    }

    public void March()
    {
        Console.WriteLine($"{this.SquadName} has begun marching.");
        Speed = 1;
    }

    public void TurnLeft(float degrees)
    {
        Console.WriteLine($"{this.SquadName} has turned {degrees} degrees to the left.");
        Direction += degrees;
    }

    public void TurnRight(float degrees)
    {
        Console.WriteLine($"{this.SquadName} has turned {degrees} degrees to the right.");
        Direction -= degrees;
    }

    public void IncreaseSpeed(int speed)
    {
        Console.WriteLine($"{this.SquadName} has increased its speed by {speed}.");
        Speed += speed;
        Console.WriteLine($"{this.SquadName} is marching at {Speed} kph.");
    }

    public void DecreaseSpeed(int speed)
    {
        Console.WriteLine($"{this.SquadName} has decreased its speed by {speed}.");
        Speed -= speed;
        Console.WriteLine($"{this.SquadName} is marching at {Speed} kph.");
    }
}
