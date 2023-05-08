using CommandTroops.Models;

namespace CommandTroops.Commands;

public class MarchThenIncreaseSpeedCommand : ICommand
{
    private readonly ITroop troop;
    private int speed;
    
    public MarchThenIncreaseSpeedCommand(ITroop _troop, int _speed)
    {
        troop = _troop;
        speed = _speed;
    }

    public void Execute()
    {
        troop.March();
        troop.IncreaseSpeed(speed);

    }

    public void Undo()
    {
        troop.DecreaseSpeed(speed);
        troop.Halt();
    }
}
