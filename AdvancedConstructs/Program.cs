using System.Globalization;
using System.Data;
// Methods
// returnType MethodName(paramtype paramName, ){}
/*

Console.Write("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition : {a + b}");
}

Add(num1, num2);
Add(1, 2);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b> largest)
    {
        largest = b;
    }
    if (c> largest) 
    {
        largest = c;
    }
    return largest;
}

int largest = GreaterThan(10, 15, 8); //15
Console.WriteLine($"largest number is {largest}");
*/


// String Manipulation
// Concatination


string firstName = "ramdas";
string lastName = "das";

string fullName = firstName+ " " + lastName;

// Length of String
int length = firstName.Length;
Console.WriteLine($"the first name has {length}");

// Replace string parts
string newFirstName = firstName.Replace("das", "esh"); 
Console.WriteLine($"New first name is {newFirstName}");

// Split
string toSplit = "Jerrish, Mithun, Jerald, Jijo, Tomson"; 
string[] names = toSplit.Split(", "); 
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

//compare

string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";


if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullDtring is empty or null");
}
if (string.IsNullOrWhiteSpace(whiteSpaceString))
{
    Console.WriteLine("nullDtring is empty or null");
}
int res = firstName.CompareTo(lastName);



if (firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstname and lastname are equal");
}
if (firstName.Equals(lastName))
{
    Console.WriteLine("firstname and lastname are equal");
}

/*
// DateTime related functionality
// Empty dateTIme
DateTime date = new DateTime();

// Create DateTime from date
DateTime dateOfBirth = new DateTime(1980, 1, 25);
Console.WriteLine($"parsed date is {dateOfBirth}");

// Create DateTime from string
DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture); 
Console.WriteLine($"Parsed date is {parsedDate}");


// Create DateTime from current timestamp
DateTime now = DateTime.Now; 
Console.WriteLine($"Current time is {now}");

// Date to ticks
Console.WriteLine($"Ticks for now is {now.Ticks}");

// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now. AddHours(2)}");

// DateOnly
DateOnly dob = DateOnly. FromDateTime(dateOfBirth); 
Console.WriteLine(dob);

// TimeOnly
TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth); 
Console.WriteLine(tob);


// Exception Handling

Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    double quotient = num1 / num2;
    Console.WriteLine($"result is {quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");

}
catch (Exception ex)
{
    Console.WriteLine("Excited the program");
}



// Arrays
// initialised a fixed size array
int[] marks = new int[5]; // 0 besed index (0-4)

// iterate an array
for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks :");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}

//print an array of elements
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

string[] usernames = new string[] { "John", "Jake", "jobe" };

// Lists

List<string> devs = new List<string>(); 
string dev = string.Empty;

while (!dev.Equals("-1"))
{
    Console.Write("Enter the name of the develepor: ");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}
foreach (string name in devs)
{
    Console.WriteLine(name);
}


// API documentation
*/