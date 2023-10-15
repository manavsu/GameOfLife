// See https://aka.ms/new-console-template for more information


using GameOfLife;

var universe = new Universe(100, 100);
var printer = new ConsolePrinter(universe);
universe.EmbedPattern(Pattern.Glider(new Coordinate(0, 0)));
universe.EmbedPattern(Pattern.Glider(new Coordinate(5, 5)));

while (true) {
    printer.Print();
    universe.Increment();
    Thread.Sleep(100);
}