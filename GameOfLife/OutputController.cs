// Created on 2023-10-14 by Manavjot Singh

namespace GameOfLife; 

class OutputController {
    const string TopLeftCorner = "\u2554";
    const string TopRightCorner = "\u2557";
    const string BottomLeftCorner = "\u255A";
    const string BottomRightCorner = "\u255D";
    const string HorizontalLine = "\u2550";
    const string VerticalLine = "\u2551";

    int _borderOffset = 1;
    
    const string Alive = "\u2588\u258B";
    const string DeadChar = "  ";
    readonly Universe _universe;
    
    public OutputController(Universe universe) {
        _universe = universe;
        Console.CursorVisible = false;
    }

    void PrintBorder() {
        Console.SetCursorPosition(0, 0);
        Console.Write(TopLeftCorner);
        for (var i = 0; i < _universe.Width * 2; i++) Console.Write(HorizontalLine);
        Console.Write(TopRightCorner);
        for (var i = 0; i < _universe.Height; i++) {
            Console.SetCursorPosition(0, 1 + i);
            Console.Write(VerticalLine);
            Console.SetCursorPosition(1 + _universe.Width * 2, 1 + i);
            Console.Write(VerticalLine);
        }
        Console.SetCursorPosition(0, 1 + _universe.Height);
        Console.Write(BottomLeftCorner);
        for (var i = 0; i < _universe.Width * 2; i++) Console.Write(HorizontalLine);
        Console.Write(BottomRightCorner);
    }

    public void PrintCells() {
        foreach (var c in _universe.Cells) {
            Console.SetCursorPosition(1 + c.Location.X * 2, 1 + c.Location.Y);
            Console.Write(c.Alive ? Alive : DeadChar);
        }
    }
}