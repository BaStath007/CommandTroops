using CommandTroops.Models;

namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is a concrete Command class that is responsible
/// for making the troops increase their marching speed.
/// 
/// </summary>
public class IncreaseSpeedCommand : ICommand
{
    private readonly ITroop troop;

    private readonly int speed;

    public IncreaseSpeedCommand(Infantry _troop, int _speed)
    {
        troop = _troop;
        speed = _speed;
    }

    public void Execute()
    {
        troop.IncreaseSpeed(speed);
    }

    public void Undo()
    {
        troop.DecreaseSpeed(speed);
    }
}
