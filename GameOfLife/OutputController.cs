// Created on 2023-10-14 by Manavjot Singh
// (c) Amber Kinetics 2023

namespace GameOfLife; 

class OutputController {
    const string TopLeftCorner = "\u250C";
    const string TopRightCorner = "\u2510";
    const string BottomLeftCorner = "\u2514";
    const string BottomRightCorner = "\u2518";
    const string HorizontalLine = "\u2500";
    const string VerticalLine = "\u2502";
    
    const string Alive = "\u2588\u258B";
    const string DeadChar = "  ";
    readonly Universe _universe;
    
    public OutputController(Universe universe) {
        _universe = universe;
        Console.CursorVisible = false;
    }

    void PrintOutline() {
        
    }

    public void PrintCells() {
        foreach (var c in _universe.Cells) {
            Console.Write(DeadChar);
            Console.SetCursorPosition(c.Location.X * 2, c.Location.Y);
            Console.Write(c.Alive ? Alive : DeadChar);
        }
    }
}