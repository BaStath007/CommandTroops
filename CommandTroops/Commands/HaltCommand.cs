using CommandTroops.Models;

namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is a concrete Command class that is responsible
/// for making the troops stop marching.
/// 
/// </summary>
public class HaltCommand : ICommand
{
    private readonly ITroop troop;

    public HaltCommand(ITroop _troop)
    {
        troop = _troop;
    }

    public void Execute()
    {
        troop.Halt();
    }

    public void Undo()
    {
        troop.March();
    }
}
