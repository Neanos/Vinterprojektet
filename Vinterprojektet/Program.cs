using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Snake");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.VIOLET);
    Raylib.DrawRectangle(20, 20, 50, 50, Color.BEIGE);

    Raylib.EndDrawing();
}
