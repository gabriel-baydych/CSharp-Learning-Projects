// TASK: Weighted average calculator for student grades.
// You will need to conceive a simple program that calculates and displays a student’s final weighted average.
// Your program will need to:
// 1) Ask the user for the grade (out of 100) of evaluation 1, 2 and 3.
// 2) Ask the user for the weighting percentage of each evaluation.
// 3) Compute the weighting rates (percentage ÷ 100).
// 4) Calculate the final weighted average.
// 5) Display the student’s final weighted average as a percentage.

//Variable declaration
double gradeEvaluation1;
double gradeEvaluation2;
double gradeEvaluation3;

double weightingRateEvaluation1;
double weightingRateEvaluation2;
double weightingRateEvaluation3;

double weightingPercentageEvaluation1;
double weightingPercentageEvaluation2;
double weightingPercentageEvaluation3;

double finalWeightedAverage;

//Input reading
Console.WriteLine("Please enter the student’s grade out of 100 for evaluation 1:");
gradeEvaluation1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the weighting percentage for evaluation 1:");
weightingPercentageEvaluation1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the student’s grade out of 100 for evaluation 2:");
gradeEvaluation2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the weighting percentage for evaluation 2:");
weightingPercentageEvaluation2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the student’s grade out of 100 for evaluation 3:");
gradeEvaluation3 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the weighting percentage for evaluation 3:");
weightingPercentageEvaluation3 = double.Parse(Console.ReadLine());

//Processing
weightingRateEvaluation1 = weightingPercentageEvaluation1 / 100;
weightingRateEvaluation2 = weightingPercentageEvaluation2 / 100;
weightingRateEvaluation3 = weightingPercentageEvaluation3 / 100;

finalWeightedAverage = (gradeEvaluation1 * weightingRateEvaluation1 + gradeEvaluation2 * weightingRateEvaluation2 + gradeEvaluation3 * weightingRateEvaluation3) / (weightingRateEvaluation1 + weightingRateEvaluation2 + weightingRateEvaluation3);

//Output display
Console.WriteLine("The student’s final weighted average is {0:0.00}%.", finalWeightedAverage);
