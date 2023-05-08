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
        Infantry IIICorps = new Infantry("Troisième corps d'armée");

        Console.WriteLine("La Grande Armée has been formed.");
        Console.WriteLine();
        commander.IssueOrder(new MarchThenIncreaseSpeedCommand(IIICorps, 1));

        commander.IssueOrder(new MarchCommand(ICorps));
        
        commander.IssueOrder(new IncreaseSpeedCommand(ICorps, 2));
        
        commander.ReissueLastOrder();
        
        commander.RescindOrder();
        
        commander.IssueOrder(new MarchCommand(IICorps));
        
        commander.IssueOrder(new IncreaseSpeedCommand(IICorps, 3));
        
        commander.IssueOrder(new DecreaseSpeedCommand(IICorps, 2));
        
        commander.IssueOrder(new TurnLeftCommand(ICorps, 45));
        
        commander.IssueOrder(new TurnRightCommand(ICorps, 90));
        
        commander.RescindOrder();

        commander.EnforceRetractedOrder();
        
        commander.IssueOrder(new HaltCommand(ICorps));
        
        commander.RescindOrder();
        
        commander.RescindOrder();
        
        commander.IssueOrder(new TurnRightCommand(IICorps, 30));
        


        Console.ReadLine();
    }
}