using CommandTroops.Commands;

namespace CommandTroops.Models;

/// <summary>
/// 
/// This is the Invoker/Sender class, that is responsible 
/// for calling an Execute() method of a certain Command Class object.
/// 
/// </summary>
public class Commander
{
    public string Name { get; set; }
    private readonly Stack<ICommand> IssuedCommands = new();
    private readonly Stack<ICommand> RetractedCommands = new();

    
    public Commander(string name)
    {
        Name = name;
    }

    // Execute
    public void IssueOrder(ICommand command)
    {
        IssuedCommands.Push(command);
        command.Execute();
    }

    // Repeat
    public void ReissueLastOrder()
    {
        if (!IssuedCommands.Any())
        {
            return;
        }
        var command = IssuedCommands.First();
        IssuedCommands.Push(command);
        command.Execute();
    }

    // Undo
    public void RescindOrder()
    {
        if (!IssuedCommands.Any())
        {
            return;
        }
        var command = IssuedCommands.Pop();
        RetractedCommands.Push(command);
        command.Undo();
    }


    // Redo
    public void EnforceRetractedOrder()
    {
        if (!RetractedCommands.Any())
        {
            return;
        }
        var command = RetractedCommands.Pop();
        IssuedCommands.Push(command);
        command.Execute();
    }
}
