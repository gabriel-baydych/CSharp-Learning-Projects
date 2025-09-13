// TASK: Code a basic program that calculates and displays the perimeter of any right-angled triangle that has the known lenght of it's hypotenuse and one of it's catheti (that will both be specified by the user).

// Variables
double knownCathetus;
double hypotenuse;

double unknownCathetus;
double perimeter;

// Read Inputs
Console.WriteLine("Please enter the lenght of the known cathetus of your right-angled triangle now :");
knownCathetus = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the lenght of the hypotenuse of your right-angled triangle now :");
hypotenuse = double.Parse(Console.ReadLine());

// Processing
unknownCathetus = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(knownCathetus, 2));
perimeter = knownCathetus + hypotenuse + unknownCathetus;

// Display Outputs
Console.WriteLine("The perimeter of your right-angled triangle is {0} units long.", perimeter);
