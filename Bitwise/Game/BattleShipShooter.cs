namespace Bitwise.Game;

public class BattleShipShooter
{
    private Map map = new Map
    {
        Rows = new byte[] {
            0b01001111,
            0b01000000,
            0b01011000,
            0b00011111,
            0b00000000,
            0b00000000,
            0b00000000,
            0b11111111
        }
    };

    public void Shoot(int x, int y)
    {
        var rowOnMap = map.Rows[x];

        var rowOnShoot = (byte)1 << y;

        if ((rowOnMap & rowOnShoot) == rowOnShoot)
        {
            Console.WriteLine("Accurate!");
        }
        else
        {
            Console.WriteLine("Missed");
        }
    }
}
