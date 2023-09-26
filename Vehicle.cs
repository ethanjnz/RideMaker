using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Vehicle
{
    string Name;
    int Passengers;
    string Color;
    bool HasEngine;
    int Miles = 0;

    // constructor one
    public Vehicle(string name, int passengers, string color, bool hasEngine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasEngine;
    }

    // constructor two
    public Vehicle(string name, string color)
    {
        Name = name;
        Color = color;
        Passengers = 1;
        HasEngine = true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I have a {Name}, with {Passengers} passenger(s), that is {Color}. it is {HasEngine} that it has a engine. It currrently has {Miles} miles on it");
    }

    public void Travel(int distance)
    {
        Miles += distance;
        Console.WriteLine($"The {Name} has currently traveled {Miles} miles");
    }

}