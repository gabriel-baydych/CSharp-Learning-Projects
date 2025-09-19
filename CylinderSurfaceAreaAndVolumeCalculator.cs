// TASK: Cylinder surface area and volume calculator.
// You will need to conceive a simple program that calculates and displays the total surface area and volume of a cylinder.
// Your program will need to:
// 1) Ask the user for the radius of the cylinder base.
// 2) Ask the user for the height of the cylinder.
// 3) Calculate the area of the circular bases and the lateral area.
// 4) Calculate the total surface area of the cylinder.
// 5) Calculate the volume of the cylinder.
// 6) Display the total surface area and the volume of the cylinder.

//Variable declaration
double cylinderRadius;
double cylinderHeight;

double circularBasesArea;
double lateralArea;

double totalCylinderArea;
double cylinderVolume;

//Input reading
Console.WriteLine("What is the radius length of the base of your cylinder?");
cylinderRadius = double.Parse(Console.ReadLine());
Console.WriteLine("What is the height of your cylinder?");
cylinderHeight = double.Parse(Console.ReadLine());

//Processing
circularBasesArea = 2 * Math.PI * Math.Pow(cylinderRadius, 2);
lateralArea = 2 * Math.PI * cylinderRadius * cylinderHeight;
totalCylinderArea = circularBasesArea + lateralArea;

cylinderVolume = (circularBasesArea / 2) * cylinderHeight;

//Output display
Console.WriteLine("The total surface area of your cylinder is {0:0.00} square units and its volume is {1:0.00} cubic units.", totalCylinderArea, cylinderVolume);
