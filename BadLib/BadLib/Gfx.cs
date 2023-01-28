using Raylib_CsLo;
using System.Numerics;

namespace BadLib;

public static class Gfx {
    public static void Line(Vector2 start, Vector2 end, Color color, float lineSize = 1) {
        RlGl.rlSetTexture(RlGl.rlGetTextureIdDefault());
        RlGl.rlSetLineWidth(lineSize);
        RlGl.rlColor4ub(color.r, color.g, color.b, color.a);

        RlGl.rlBegin(RlGl.RL_LINES);
        {
            RlGl.rlVertex2f(start.X, start.Y);
            RlGl.rlVertex2f(end.X, end.Y);
        }
        RlGl.rlEnd();
    }

    public static void RectangleLine(Vector2 position, Vector2 size, Color color, float lineSize = 1) {
        RlGl.rlSetTexture(RlGl.rlGetTextureIdDefault());
        RlGl.rlSetLineWidth(lineSize);
        RlGl.rlColor4ub(color.r, color.g, color.b, color.a);

        RlGl.rlBegin(RlGl.RL_LINES);
        {
            // Top
            RlGl.rlVertex2f(position.X, position.Y);
            RlGl.rlVertex2f(position.X + size.X, position.Y);

            // Bottom
            RlGl.rlVertex2f(position.X, position.Y + size.Y);
            RlGl.rlVertex2f(position.X + size.X, position.Y + size.Y);

            // Left
            RlGl.rlVertex2f(position.X, position.Y);
            RlGl.rlVertex2f(position.X, position.Y + size.Y);

            // Right
            RlGl.rlVertex2f(position.X + size.X, position.Y);
            RlGl.rlVertex2f(position.X + size.X, position.Y + size.Y);
        }
        RlGl.rlEnd();
    }

    public static void RectangleLine(Rectangle rectangle, Color color, float lineSize = 1) => RectangleLine(new Vector2(rectangle.X, rectangle.Y), new Vector2(rectangle.width, rectangle.height), color, lineSize);

    public static void Circle(Vector2 position, float radius, Color color, int segments = 32, float lineSize = 1) {
        if (radius <= 0.0f)
            radius = 0.01f;

        RlGl.rlSetTexture(RlGl.rlGetTextureIdDefault());
        RlGl.rlSetLineWidth(lineSize);
        RlGl.rlColor4ub(color.r, color.g, color.b, color.a);

        int stepSize = 360 / segments;

        RlGl.rlBegin(RlGl.RL_LINES);
        {
            for (int i = 0; i < 360; i += stepSize) {
                RlGl.rlVertex2f(position.X + (float)Math.Sin(RayMath.DEG2RAD * i) * radius, position.Y + (float)Math.Cos(RayMath.DEG2RAD * i) * radius);
                RlGl.rlVertex2f(position.X + (float)Math.Sin(RayMath.DEG2RAD * (i + stepSize)) * radius, position.Y + (float)Math.Cos(RayMath.DEG2RAD * (i + stepSize)) * radius);
            }
        }
        RlGl.rlEnd();
    }

    public static void CircleFilled(Vector2 position, float radius, Color color, int segments = 32) {
        if (radius <= 0.0f)
            radius = 0.01f;

        RlGl.rlSetTexture(RlGl.rlGetTextureIdDefault());
        RlGl.rlColor4ub(color.r, color.g, color.b, color.a);

        int stepSize = 360 / segments;

        RlGl.rlBegin(RlGl.RL_TRIANGLES);
        {
            for (int i = 0; i < 360; i += stepSize) {
                RlGl.rlVertex2f(position.X, position.Y);
                RlGl.rlVertex2f(position.X + (float)Math.Sin(RayMath.DEG2RAD * i) * radius, position.Y + (float)Math.Cos(RayMath.DEG2RAD * i) * radius);
                RlGl.rlVertex2f(position.X + (float)Math.Sin(RayMath.DEG2RAD * (i + stepSize)) * radius, position.Y + (float)Math.Cos(RayMath.DEG2RAD * (i + stepSize)) * radius);
            }
        }
        RlGl.rlEnd();
    }

    public static void CircleFilledOutline(Vector2 position, float radius, Color color, Color outlineColor, int segments = 32, float lineSize = 1) {
        CircleFilled(position, radius, color, segments);
        Circle(position, radius, outlineColor, segments, lineSize);
    }

    public static void Texture(Texture texture, Vector2 position, float scale, Color color) => Raylib.DrawTextureEx(texture, position, 0, scale, color);
}
