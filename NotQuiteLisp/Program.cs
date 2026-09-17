using AdventOfCode.Common;
using NotQuiteLisp;

Console.WriteLine("Hello!");

var path = Path.Combine(AppContext.BaseDirectory, "Data.txt");
var text = File.ReadAllText(path);

var allSteps = Input.Lines(text);

var stairs = new Stairs();
var floor = stairs.GetFloor(allSteps.First());

Console.WriteLine("Santa ended up on floor: " + floor);
