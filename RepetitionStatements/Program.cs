﻿// for ( counter Controlled)
for (int i =0; i < 10; i++)
{
    Console.WriteLine($"Inside loop {i}");
}

Console.WriteLine();
Console.WriteLine("for loop exited");

//while (condition controlled)

int n= 10;
while (n < 5)
{
    Console.Write("enter the value for n: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Inside while loop {n}");
}
Console.WriteLine();
Console.WriteLine("while loop exited");

// do while ( condition controlled, post check )
int j = 10;
do
{
    Console.Write("Enter the value for j: ");
    j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Inside do while loop {j}");
}
while (j < 5);
Console.WriteLine();
Console.WriteLine("do while loop exited");