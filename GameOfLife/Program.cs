// See https://aka.ms/new-console-template for more information


using GameOfLife;

var universe = new Universe(50, 100);
var printer = new OutputController(universe);
var timer = new IntervalTimer(TimeSpan.FromMilliseconds(100));

universe.EmbedPattern(Pattern.GliderGun(new Coordinate(0, 0)));

while (true) {
    universe.Tick();
    printer.PrintCells();
    timer.Wait();
}