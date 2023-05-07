using CommandTroops.Models;

namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is a concrete Command class that is responsible
/// for making the troops turn right by a certain amount of degrees.
/// 
/// </summary>
public class TurnRightCommand : ICommand
{
    private readonly ITroop troop;

    private readonly float degrees;

    public TurnRightCommand(Infantry _troop, float _degrees)
    {
        troop = _troop;
        degrees = _degrees;
    }

    public void Execute()
    {
        troop.TurnRight(degrees);
    }

    public void Undo()
    {
        troop.TurnLeft(degrees);
    }
}
