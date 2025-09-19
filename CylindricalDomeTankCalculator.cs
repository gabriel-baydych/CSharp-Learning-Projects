// TASK: Cylindrical dome tank volume and surface area calculator.
// You will need to conceive a simple program that calculates and displays the volume and surface area of a tank composed of a cylinder with a dome on top.
// Your program will need to:
// 1) Ask the user for the radius of the circular base of the cylinder part in meters.
// 2) Ask the user for the height of the cylindrical part in meters.
// 3) Calculate the volume of the cylindrical part, the dome part, and the total volume.
// 4) Calculate the lateral surface area of the cylinder, the surface area of the dome, the lower circular base area, and the total outer surface area.
// 5) Display all calculated volumes and surface areas.

//Variable declaration
double radius;
double cylinderHeight;

double cylinderVolume;
double domeVolume;
double totalTankVolume;

double cylinderLateralArea;
double domeSurfaceArea;
double cylinderBottomArea;
double totalTankSurfaceArea;

//Input reading
Console.WriteLine("What is the radius of the circular base of the cylinder part of the tank in meters?");
radius = double.Parse(Console.ReadLine());
Console.WriteLine("What is the height of the cylindrical part of the tank in meters?");
cylinderHeight = double.Parse(Console.ReadLine());

//Processing
cylinderVolume = Math.PI * cylinderHeight * Math.Pow(radius, 2);
domeVolume = 4.0 / 3 * Math.PI * Math.Pow(radius, 3);
totalTankVolume = cylinderVolume + domeVolume;

cylinderLateralArea = 2 * Math.PI * radius * cylinderHeight;
domeSurfaceArea = 2 * Math.PI * Math.Pow(radius, 2);
cylinderBottomArea = Math.PI * Math.Pow(radius, 2);
totalTankSurfaceArea = cylinderLateralArea + domeSurfaceArea + cylinderBottomArea;

//Output display
Console.WriteLine("The volume of the cylindrical part of the tank is {0:0.00} cubic meters, the volume of the dome part of the tank is {1:0.00} cubic meters, and the total tank volume is {2:0.00} cubic meters. The lateral surface area of the cylinder is {3:0.000} square meters, the surface area of the dome is {4:0.000} square meters, the area of the lower circular base is {5:0.000} square meters, and the total outer surface area of the tank is {6:0.000} square meters.", cylinderVolume, domeVolume, totalTankVolume, cylinderLateralArea, domeSurfaceArea, cylinderBottomArea, totalTankSurfaceArea);
