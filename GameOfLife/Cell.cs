// Created on 2023-09-23 by Manavjot Singh
// (c) Amber Kinetics 2023

namespace GameOfLife; 

class Cell
{
    public bool Alive { get; private set; }
    public bool NextState { get; set; }
    public Coordinate Location { get; }
    
    public Cell (Coordinate location) : this(false, location) { }
    
    public Cell(bool alive, Coordinate location) 
    {
        Alive = alive;
        Location = location;
    }
    
    public void UpdateState() => Alive = NextState;
    
    public override string ToString() => $"Cell {Location} {(Alive ? "alive" : "dead")}";
}