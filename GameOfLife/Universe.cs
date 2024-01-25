// Created on 2023-09-23 by Manavjot Singh

using System.Diagnostics;

namespace GameOfLife;

class Universe {
    public int Height { get; }
    public int Width { get; }

    readonly Dictionary<Cell, Cell[]> _neighbors = new();

    public Cell[] Cells { get; }
    public Rules Rules { get; }

    public Universe(int height, int width) : this(height, width, new Rules()) { }

    public Universe(int height, int width, Rules rules) {
        Height = height;
        Width = width;
        Rules = rules;
        Cells = Coordinate.CreateCoordinateSet(Height, Width).Select(c => new Cell(c)).ToArray();
        foreach (var cell in Cells) _neighbors[cell] = GetNeighbors(cell);
    }

    public void Tick() {
        UpdateState();
        CalculateNextState();
    }

    public void CalculateNextState() {
        foreach (var cell in Cells) cell.NextState = GetNextCellState(cell);
    }

    public void UpdateState() {
        foreach (var cell in Cells) cell.UpdateState();
    }

    bool GetNextCellState(Cell cell) {
        var numNeighborsAlive = GetNumNeighborsAlive(cell);
        return cell.Alive ? Rules.PersistenceRule(numNeighborsAlive) : Rules.EmergenceRule(numNeighborsAlive);
    }

    int GetNumNeighborsAlive(Cell cell) {
        return _neighbors[cell].Count(c => c.Alive);
    }
    
    Cell[] GetNeighbors(Cell cell) {
        return Cells.Where(c => IsNeighbor(cell, c)).ToArray();
    }

    bool IsNeighbor(Cell cell, Cell other) {
        if (cell.Location == other.Location) return false;
        var xDiff = Math.Abs(cell.Location.X - other.Location.X);
        var yDiff = Math.Abs(cell.Location.Y - other.Location.Y);
        if (!Rules.WrapEdges) return xDiff <= 1 && yDiff <= 1;
        if (xDiff == Width - 1) xDiff = 1;
        if (yDiff == Height - 1) yDiff = 1;
        return xDiff <= 1 && yDiff <= 1;
    }

    public void EmbedPattern(Pattern pattern) {
        foreach (var p in pattern.Coordinates) {
            var cell = Cells.Single(c => c.Location == p);
            cell.NextState = true;
        }
    }
}
