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
    
    public static Pattern Blinker(Coordinate location) {
        return new Pattern(new[] {
            new Coordinate(0, 0),
            new Coordinate(0, 1),
            new Coordinate(0, 2)
        }.Select(c => new Coordinate(c.X + location.X, c.Y + location.Y)).ToArray());
    }
    
    public static Pattern Toad(Coordinate location) {
        return new Pattern(new[] {
            new Coordinate(0, 1),
            new Coordinate(0, 2),
            new Coordinate(0, 3),
            new Coordinate(1, 0),
            new Coordinate(1, 1),
            new Coordinate(1, 2)
        }.Select(c => new Coordinate(c.X + location.X, c.Y + location.Y)).ToArray());
    }
    
    public static Pattern Beacon(Coordinate location) {
        return new Pattern(new[] {
            new Coordinate(0, 0),
            new Coordinate(0, 1),
            new Coordinate(1, 0),
            new Coordinate(1, 1),
            new Coordinate(2, 2),
            new Coordinate(2, 3),
            new Coordinate(3, 2),
            new Coordinate(3, 3)
        }.Select(c => new Coordinate(c.X + location.X, c.Y + location.Y)).ToArray());
    }

    public static Pattern GliderGun(Coordinate location) {
        return new Pattern(new[] {
            new Coordinate(0, 24),
            new Coordinate(1, 22),
            new Coordinate(1, 24),
            new Coordinate(2, 12),
            new Coordinate(2, 13),
            new Coordinate(2, 20),
            new Coordinate(2, 21),
            new Coordinate(2, 34),
            new Coordinate(2, 35),
            new Coordinate(3, 11),
            new Coordinate(3, 15),
            new Coordinate(3, 20),
            new Coordinate(3, 21),
            new Coordinate(3, 34),
            new Coordinate(3, 35),
            new Coordinate(4, 0),
            new Coordinate(4, 1),
            new Coordinate(4, 10),
            new Coordinate(4, 16),
            new Coordinate(4, 20),
            new Coordinate(4, 21),
            new Coordinate(5, 0),
            new Coordinate(5, 1),
            new Coordinate(5, 10),
            new Coordinate(5, 14),
            new Coordinate(5, 16),
            new Coordinate(5, 17),
            new Coordinate(5, 22),
            new Coordinate(5, 24),
            new Coordinate(6, 10),
            new Coordinate(6, 16),
            new Coordinate(6, 24),
            new Coordinate(7, 11),
            new Coordinate(7, 15),
            new Coordinate(8, 12),
            new Coordinate(8, 13)
        }.Select(c => new Coordinate(c.X + location.X, c.Y + location.Y)).ToArray());
    }
}