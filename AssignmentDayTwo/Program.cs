// ATM

double balance = 1000;
int cardNumber = 0;
int pin = 0;
int choice = 0;
double withdrawal = 0.0;
double deposit = 0.0;

void UserBalance()
{
    Console.WriteLine($"Your current balance is : " + balance);
}

void UserWithdrawal()
{
    double withdrawal = 0.0;
    Console.Write("Enter the amount to withdraw : ");
    withdrawal = Convert.ToDouble(Console.ReadLine());
    if (withdrawal > balance)
    {
        Console.WriteLine("The withdrawal amount exceeded the balance amount ");
    }
    else
    {
        balance -= withdrawal;
        Console.WriteLine("Please collect your cash");
        UserBalance();
    }
}

void UserDeposit()
{
    Console.Write("Enter the amount to deposit: ");
    deposit = Convert.ToDouble(Console.ReadLine());
    if (deposit == 0)
    {
        UserBalance();
    }
    else
    {
        balance += deposit;
        Console.WriteLine("Your balance is updated");
        UserBalance();
    }
    
}

void UserMenu()
{
    Console.WriteLine("Welcome to atm service");
    Console.WriteLine("Enter 1 to check balance");
    Console.WriteLine("Enter 2 to withdraw amount");
    Console.WriteLine("Enter 3 to deposit amount");
    Console.WriteLine("Enter 4 to quit the program");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

void UserThankyou()
{
    Console.WriteLine("Thankyou for using ATM ");
}

try
{
    Console.Write("Enter your Card number: ");
    cardNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter your pin code: ");
    pin = Convert.ToInt32(Console.ReadLine());
    if (cardNumber == 12345 && pin == 1234)
    {
        while (!choice.Equals(4))
        {
            UserMenu();
            switch (choice)
            {
                case 1:
                    UserBalance();
                    break;
                case 2:
                    UserWithdrawal();
                    break;
                case 3:
                    UserDeposit();
                    break;
                case 4:
                    UserThankyou();
                    break;
            }
        }   
    }
    else
    {
        Console.WriteLine("Invalid card number or pin");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
