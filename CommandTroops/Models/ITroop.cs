namespace CommandTroops.Models;

public interface ITroop
{
    void March();
    void TurnRight(float degrees);
    void TurnLeft(float degrees);
    void IncreaseSpeed(int speed);
    void DecreaseSpeed(int speed);
    void Halt();
}
