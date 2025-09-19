// TASK: Right triangle perimeter calculator.
// You will need to conceive a simple program that calculates and displays the perimeter of a right triangle when one leg and the hypotenuse are known.
// Your program will need to:
// 1) Ask the user for the length of one leg of the right triangle.
// 2) Ask the user for the length of the hypotenuse.
// 3) Calculate the unknown leg using the Pythagorean theorem.
// 4) Calculate the perimeter of the triangle.
// 5) Display the perimeter.

//Variable declaration
double knownLeg;
double hypotenuse;

double unknownLeg;
double perimeter;

//Input reading
Console.WriteLine("Please enter the length of one leg of your right triangle:");
knownLeg = double.Parse(Console.ReadLine());

Console.WriteLine("Now enter the length of the hypotenuse of your right triangle:");
hypotenuse = double.Parse(Console.ReadLine());

//Processing
unknownLeg = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(knownLeg, 2));
perimeter = knownLeg + hypotenuse + unknownLeg;

//Output display
Console.WriteLine("The perimeter of your right triangle is {0} units long.", perimeter);
