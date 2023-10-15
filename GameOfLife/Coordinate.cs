// Created on 2023-09-23 by Manavjot Singh
// (c) Amber Kinetics 2023

namespace GameOfLife; 

struct Coordinate : IEquatable<Coordinate> {
    public int X { get; }
    public int Y { get; }
    
    public Coordinate(int x, int y) {
        X = x;
        Y = y;
    }

    public static Coordinate[] CreateCoordinateSet(int height, int width) {
        var coordinates = new Coordinate[height * width];
        var cnt = 0;
        for (var i = 0; i < width; i++) {
            for (var j = 0; j < height; j++) coordinates[cnt++] = new Coordinate(i, j);
        }
        return coordinates;
    }
    
    public static bool operator ==(Coordinate left, Coordinate right) {
        return left.Equals(right);
    }
    
    public static bool operator !=(Coordinate left, Coordinate right) {
        return !left.Equals(right);
    }

    public bool Equals(Coordinate other) {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj) {
        return obj is Coordinate other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine(X, Y);
    }
    
    public override string ToString() => $"({X}, {Y})";
}