double a = 0;
double b = 0;
double c = 0;

Console.Write("Enter a number: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter another number: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter another last number: ");
c = Convert.ToDouble(Console.ReadLine());

double result = (((a + b) / c) * a);

Console.WriteLine($"The result of the equation: {result}");



