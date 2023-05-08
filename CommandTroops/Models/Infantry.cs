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
    public int Direction { get; set; } = 90;
    public int Speed { get; set; } = 0;

    public Infantry(string squadName)
    {
        SquadName = squadName;
    }

    public void Halt()
    {
        Console.WriteLine($"{this.SquadName} has stoped marching.");
        Console.WriteLine();
        Speed = 0;
    }

    public void March()
    {
        Console.WriteLine($"{this.SquadName} has begun marching.");
        Console.WriteLine();
        Speed = 1;
    }

    public void TurnLeft(int degrees)
    {
        Console.WriteLine($"{this.SquadName} has turned {degrees} degrees to the left.");
        Direction += degrees;
        int quontient = Direction / 360;
        int direction = Direction - (quontient * 360);
        Console.WriteLine($"{this.SquadName} direction is {direction} degrees.");
        Console.WriteLine();
    }

    public void TurnRight(int degrees)
    {
        Console.WriteLine($"{this.SquadName} has turned {degrees} degrees to the right.");
        Direction -= degrees;
        int quontient = Direction / 360;
        int direction = Direction - (quontient * 360);
        Console.WriteLine($"{this.SquadName} direction is {direction} degrees.");
        Console.WriteLine();
    }

    public void IncreaseSpeed(int speed)
    {
        Console.WriteLine($"{this.SquadName} has increased its speed by {speed} km/h.");
        Speed += speed;
        Console.WriteLine($"{this.SquadName} is marching at {Speed} km/h.");
        Console.WriteLine();
    }

    public void DecreaseSpeed(int speed)
    {
        Console.WriteLine($"{this.SquadName} has decreased its speed by {speed} km/h.");
        Speed -= speed;
        Console.WriteLine($"{this.SquadName} is marching at {Speed} km/h.");
        Console.WriteLine();
    }
}
