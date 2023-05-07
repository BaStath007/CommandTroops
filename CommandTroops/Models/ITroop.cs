namespace CommandTroops.Models;

public interface ITroop
{
    void March();
    void TurnRight(int degrees);
    void TurnLeft(int degrees);
    void IncreaseSpeed(int speed);
    void DecreaseSpeed(int speed);
    void Halt();
}
