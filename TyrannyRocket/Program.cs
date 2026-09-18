using AdventOfCode.Common;
using TyrannyRocket;

Console.WriteLine("Hello, World!");
var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
var text = File.ReadAllText(path);

var massArray = Input.Numbers(text);
var rocket = new Rocket();

var totalFuel = 0;

foreach (var mass in massArray)
{
    var fuelRequirements = rocket.CalculateFuelRequirements(mass);
    totalFuel += fuelRequirements;
}

Console.WriteLine("Fuel Requirements");
Console.WriteLine(totalFuel);

Console.WriteLine("---------------");
