namespace CommandTroops.Commands;

/// <summary>
/// 
/// This is the Interface that all concrete command classes are using.
/// 
/// </summary>
public interface ICommand
{
    public void Execute();
    public void Undo();
}
