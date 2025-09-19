// TASK : Euclidean distance calculator between two points.
// You will need to conceive a simple program that calculates and displays the Euclidean distance between two points in a 2D plane.
// Your program will need to:
// 1) Ask the user for the x and y coordinates of the first point.
// 2) Ask the user for the x and y coordinates of the second point.
// 3) Calculate the Euclidean distance using the distance formula.
// 4) Display the Euclidean distance between the two points.

//Variable declaration
double x1;
double y1;
double x2;
double y2;

double euclideanDistance;

//Input reading
Console.WriteLine("What is the x-coordinate of your first point?");
x1 = double.Parse(Console.ReadLine());
Console.WriteLine("What is the y-coordinate of your first point?");
y1 = double.Parse(Console.ReadLine());
Console.WriteLine("What is the x-coordinate of your second point?");
x2 = double.Parse(Console.ReadLine());
Console.WriteLine("What is the y-coordinate of your second point?");
y2 = double.Parse(Console.ReadLine());

//Processing
euclideanDistance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

//Output display
Console.WriteLine("The Euclidean distance between your two points is {0:0.00} units long.", euclideanDistance);
