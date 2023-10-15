// See https://aka.ms/new-console-template for more information


using GameOfLife;

var universe = new Universe(100, 100);
var printer = new ConsolePrinter(universe);
var timer = new IntervalTimer(TimeSpan.FromMilliseconds(100));
universe.EmbedPattern(Pattern.Glider(new Coordinate(0, 0)));
universe.EmbedPattern(Pattern.Glider(new Coordinate(5, 5)));

while (true) {
    printer.Print();
    universe.Tick();
    timer.Wait();
}