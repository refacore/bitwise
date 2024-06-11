using Bitwise.Game;

namespace Bitwise;

public static class GameTest
{
    public static void Run()
    {
        var battleShipShooter = new BattleShipShooter();

        battleShipShooter.Shoot(3, 4);

        battleShipShooter.Shoot(1, 5);

        battleShipShooter.Shoot(5, 5);
    }
}
