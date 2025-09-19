// TASK: Sphere mass calculator.
// You will need to conceive a simple program that calculates and displays the mass of a sphere based on its radius and material density.
// Your program will need to:
// 1) Ask the user for the radius of the sphere in centimeters.
// 2) Ask the user for the material density of the sphere in grams per cubic centimeter.
// 3) Calculate the volume of the sphere.
// 4) Convert the mass from grams to kilograms.
// 5) Display the mass of the sphere in kilograms.

//Constant declaration
const double GramsToKilogramsFactor = 1.0 / 1000;

//Variable declaration
double sphereRadiusCm;
double sphereMaterialDensityGramsPerCmCube;

double sphereVolume;

double sphereMassKg;

//Input reading
Console.WriteLine("What is the radius of your sphere in centimeters?");
sphereRadiusCm = double.Parse(Console.ReadLine());
Console.WriteLine("What is the material density of the sphere in grams per cubic centimeter?");
sphereMaterialDensityGramsPerCmCube = double.Parse(Console.ReadLine());

//Processing
sphereVolume = 4 * Math.PI * Math.Pow(sphereRadiusCm, 3) / 3;
sphereMassKg = (sphereMaterialDensityGramsPerCmCube * sphereVolume) * GramsToKilogramsFactor;

//Output display
Console.WriteLine("The mass of your sphere is {0:0.0000} kilograms.", sphereMassKg);
