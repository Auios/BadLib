using Raylib_CsLo;
using System.Numerics;

namespace BadLib;

public static class Window
{
    static Vector2 size;
    static string? title;
    static Image icon;

    public static void Init(int width, int height, string title = "Game", string? iconPath = null)
    {
        size = new Vector2(width, height);
        Window.title = title;

        Raylib.SetConfigFlags(ConfigFlags.FLAG_MSAA_4X_HINT | ConfigFlags.FLAG_WINDOW_RESIZABLE);
        Raylib.InitWindow((int)size.X, (int)size.Y, Window.title);
        Raylib.SetWindowMinSize(400, 300);
        Raylib.SetWindowIcon(icon);
        Raylib.SetExitKey(0);
        Raylib.InitAudioDevice();

        if (iconPath != null) {
            icon = Raylib.LoadImage(iconPath);
        }
    }

    public static void Close()
    {
        Raylib.UnloadImage(icon);
        Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
    }

    public static void Update() {
        if (Raylib.IsWindowResized()) {
            size = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
        }
    }

    public static int Width => (int)size.X;
    public static int Height => (int)size.Y;

    public static Vector2 Size => size;
    public static Vector2 Center => size * 0.5f;
}
