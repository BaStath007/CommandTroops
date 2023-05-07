using CommandTroops.Models;

namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is a concrete Command class that is responsible
/// for making the troops decrease their marching speed.
/// 
/// </summary>
public class DecreaseSpeedCommand : ICommand
{
    private readonly ITroop troop;

    private readonly int speed;

    public DecreaseSpeedCommand(Infantry _troop, int _speed)
    {
        troop = _troop;
        speed = _speed;
    }

    public void Execute()
    {
        troop.DecreaseSpeed(speed);
    }

    public void Undo()
    {
        troop.IncreaseSpeed(speed);
    }
}
