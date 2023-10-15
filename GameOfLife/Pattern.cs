// Created on 2023-10-14 by Manavjot Singh
// (c) Amber Kinetics 2023

using System.Collections.Immutable;

namespace GameOfLife; 

class Pattern {
    public Coordinate[] Coordinates { get; }

    public Pattern(Coordinate[] coordinates) {
        Coordinates = coordinates;
    }

    public static Pattern Glider(Coordinate location) {
        return new Pattern(new[] {
            new Coordinate(0, 1),
            new Coordinate(1, 2),
            new Coordinate(2, 0),
            new Coordinate(2, 1),
            new Coordinate(2, 2)
        }.Select(c => new Coordinate(c.X + location.X, c.Y + location.Y)).ToArray());
    }
}