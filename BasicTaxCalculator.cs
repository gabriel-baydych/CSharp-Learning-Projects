// TASK GIVEN: Price calculator with tax.
// You will need to conceive a simple program that calculates and displays the total cost of an order, including sales taxes.
// Your program will need to:
// 1) Ask the user the unit price of the product.
// 2) Ask the user the desired product amount.
// 3) Calculate the subtotal (price before taxes).
// 4) Calculate the GST (Goods and Services Tax) and QST (Quebec Sales Tax) amounts on that subtotal.
// 5) Display the subtotal, the GST amount the QST amount and the final total cost.

// -------------------------------------------------

// Constants
const double GSTFactor = 0.05;
const double QSTFactor = 0.09975;

// Variables
double unitPriceProduct;
int productAmount;
double priceBeforeTaxes;
double amountGST;
double amountQST;
double finalPrice;

// Read inputs
Console.WriteLine("Enter the unit price of the product: ");
unitPriceProduct = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the quantity of products: ");
productAmount = int.Parse(Console.ReadLine());

// Processing
priceBeforeTaxes = unitPriceProduct * productAmount;
amountGST = priceBeforeTaxes * GSTFactor;
amountQST = priceBeforeTaxes * QSTFactor;
finalPrice = priceBeforeTaxes + amountGST + amountQST;

// Display outputs
Console.WriteLine("Invoice:");
Console.Write("Subtotal: ");
Console.WriteLine(priceBeforeTaxes);

Console.Write("GST amount: ");
Console.WriteLine(amountGST);

Console.Write("QST amount: ");
Console.WriteLine(amountQST);

Console.Write("Total amount to pay: ");
Console.WriteLine(finalPrice);
