// Operations(+,-,*,/,%)

int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"multiplication: {num1 * num2}");
Console.WriteLine($"division: {num1 / num2}");
Console.WriteLine($"Addition: {num1 + num2}");

num1 = num1+ 9;
Console.WriteLine($"new value for num1: {num1}");
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"multiplication: {num1 * num2}");
Console.WriteLine($"division: {num1 / num2}");
Console.WriteLine($"Addition: {num1 + num2}");

// compound assignment

num1 += 10;
Console.WriteLine($"New value for num1 after += {num1}");
num1 -= 10;
Console.WriteLine($"New value for num1 after -= {num1}");
num1 *= 10;
Console.WriteLine($"New value for num1 after *= {num1}");
num1 /= 10;
Console.WriteLine($"New value for num1 after /= {num1}");
num1 %= 10;
Console.WriteLine($"New value for num1 after %= {num1}");