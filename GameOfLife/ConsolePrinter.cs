// Created on 2023-10-14 by Manavjot Singh
// (c) Amber Kinetics 2023

namespace GameOfLife; 

class ConsolePrinter {
    const string Alive = "\u2588\u258B";
    const string DeadChar = "  ";
    readonly Universe _universe;
    
    public ConsolePrinter(Universe universe) {
        _universe = universe;
        Console.CursorVisible = false;
    }

    public void Print() {
        foreach (var c in _universe.Cells) {
            Console.Write(DeadChar);
            Console.SetCursorPosition(c.Location.X * 2, c.Location.Y);
            Console.Write(c.Alive ? Alive : DeadChar);
        }
    }
}