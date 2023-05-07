using CommandTroops.Commands;
using CommandTroops.Models;

namespace CommandTroops;

/// <summary>
/// 
/// This is the Client Code.
/// 
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        Commander commander = new Commander("Napoleon");
        Infantry ICorps = new Infantry("Premier corps d'armée");
        Infantry IICorps = new Infantry("Deuxième corps d'armée");

        Console.WriteLine("La Grande Armée has been formed.");
        Console.WriteLine();
        commander.IssueOrder(new MarchCommand(ICorps));
        Console.WriteLine();
        commander.IssueOrder(new IncreaseSpeedCommand(ICorps, 2));
        Console.WriteLine();
        commander.IssueOrder(new IncreaseSpeedCommand(ICorps, 1));
        Console.WriteLine();
        commander.RescindOrder();
        Console.WriteLine();
        commander.IssueOrder(new MarchCommand(IICorps));
        Console.WriteLine();
        commander.IssueOrder(new IncreaseSpeedCommand(IICorps, 3));
        Console.WriteLine();
        commander.IssueOrder(new DecreaseSpeedCommand(IICorps, 2));
        Console.WriteLine();
        commander.IssueOrder(new TurnLeftCommand(ICorps, 45));
        Console.WriteLine();
        commander.IssueOrder(new TurnRightCommand(ICorps, 90));
        Console.WriteLine();
        commander.RescindOrder();
        Console.WriteLine();
        commander.IssueOrder(new HaltCommand(ICorps));
        Console.WriteLine();
        commander.RescindOrder();
        Console.WriteLine();
        commander.RescindOrder();
        Console.WriteLine();
        commander.IssueOrder(new TurnRightCommand(IICorps, 22.5f));
        Console.WriteLine();


        Console.ReadLine();
    }
}