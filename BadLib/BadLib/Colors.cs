using Raylib_CsLo;

namespace BadLib;

public static class Colors
{
    // Primes
    public readonly static Color BLACK = new Color(0, 0, 0, 255);
    public readonly static Color BLUE = new Color(0, 0, 255, 255);
    public readonly static Color GREEN = new Color(0, 255, 0, 255);
    public readonly static Color CYAN = new Color(0, 255, 255, 255);
    public readonly static Color RED = new Color(255, 0, 0, 255);
    public readonly static Color MAGENTA = new Color(255, 0, 255, 255);
    public readonly static Color YELLOW = new Color(255, 255, 0, 255);
    public readonly static Color WHITE = new Color(255, 255, 255, 255);

    // Grays
    public readonly static Color DARKGRAY = new Color(68, 68, 68, 255);
    public readonly static Color GRAY = new Color(128, 128, 128, 255);
    public readonly static Color LIGHTGRAY = new Color(192, 192, 192, 255);

    // Custom
    public readonly static Color MAPGRID = new Color(30, 30, 30, 255);
    public readonly static Color PATH = new Color(255, 255, 0, 20);
}
