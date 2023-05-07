using CommandTroops.Models;

namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is a concrete Command class that is responsible
/// for making the troops turn left by a certain amount of degrees.
/// 
/// </summary>
public class TurnLeftCommand : ICommand
{
    private readonly ITroop troop;

    private readonly int degrees;

    public TurnLeftCommand(Infantry _troop, int _degrees)
    {
        troop = _troop;
        degrees = _degrees;
    }

    public void Execute()
    {
        troop.TurnLeft(degrees);
    }

    public void Undo()
    {
        troop.TurnRight(degrees);
    }
}
