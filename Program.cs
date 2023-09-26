
using System.Diagnostics.Tracing;

Vehicle Toyota = new("Toyota", 2, "Black", true);
Vehicle Ford = new("Ford", 1, "White", false);
Vehicle BMW = new("BMW", "Grey");
Vehicle Chevy = new("Chevy", "Red");

// make a list of the actual instance instead of the string name
List<Vehicle> AllVehicles = new() { Toyota, Ford, BMW, Chevy };

// each [i] should be the actual info of the vehicle
for (int i = 0; i < AllVehicles.Count; i++)
{
    AllVehicles[i].ShowInfo();
}

// default value is 0 and we add 100 through the travel method
Toyota.Travel(100);
Toyota.ShowInfo();

