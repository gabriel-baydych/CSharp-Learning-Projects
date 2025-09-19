// TASK: Circle sector calculator.
// You will need to conceive a simple program that calculates and displays the arc length and area of a circle sector.
// Your program will need to:
// 1) Ask the user for the radius of the circle.
// 2) Ask the user for the angle of the sector in degrees.
// 3) Convert the angle from degrees to radians.
// 4) Calculate the arc length of the sector.
// 5) Calculate the area of the sector.
// 6) Display the arc length and the sector area.

//Constant declaration
const double DegreesToRadiansRate = Math.PI / 180;

//Variable declaration
double radius;
double sectorAngleDegrees;

double sectorAngleRadians;
double arcLength;
double sectorArea;

//Input reading
Console.WriteLine("What is the radius of your circle?");
radius = double.Parse(Console.ReadLine());
Console.WriteLine("What is the angle of the circle sector in degrees?");
sectorAngleDegrees = double.Parse(Console.ReadLine());

//Processing
sectorAngleRadians = sectorAngleDegrees * DegreesToRadiansRate;

arcLength = radius * sectorAngleRadians;
sectorArea = 0.5 * Math.Pow(radius, 2) * sectorAngleRadians;

//Output display
Console.WriteLine("The arc length of your circle is {0:0.0000} units and the area of the sector is {1:0.0000} square units.", arcLength, sectorArea);
