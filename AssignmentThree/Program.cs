// FORTUNE GAME


int chances = 5;
int guess = 0;

Random rnd = new Random();
int number = rnd.Next(0, 101);

Console.WriteLine($"You have {chances} chances to guess the number");

for (int i = 5; i > 0; i--)
{
    Console.Write("Enter a number between (0-100): ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (i > 0);
    {
        if (guess == number)
        {
            Console.WriteLine("You have won the game");
            return;
        }
        else if (guess > number)
        {
            Console.WriteLine("Your guess is greater than the number");
        }
        else if (guess < number)
        {
            Console.WriteLine("Your guess is smaller than the number");
        }
        chances--;
        Console.WriteLine($"You have {chances} chances left");
        if(chances == 0)
        {
            Console.WriteLine("You have lost the game");
            Console.WriteLine($"The number was : {number}");
        }
    }
}