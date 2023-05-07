using CommandTroops.Models;

namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is a concrete Command class that is responsible
/// for making the troops start marching.
/// 
/// </summary>
public class MarchCommand : ICommand
{
    private readonly ITroop troop;

    public MarchCommand(ITroop _troop)
    {
       troop = _troop;
    }

    public void Execute()
    {
        troop.March();
    }

    public void Undo()
    {
        troop.Halt();
    }
}
