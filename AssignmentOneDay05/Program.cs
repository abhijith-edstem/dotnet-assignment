// Bank Statement Analyser

class Program
{
    static void Main()
    {
        var analyzer = new BankStatementAnalyser();
        analyzer.LoadTransactions("C:\\Users\\ASUS\\Downloads\\test.csv");
        analyzer.GetTransactions();

        Console.Write("Enter the month to find the monthly balance:");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year to find the monthly balance:");
        int year = int.Parse(Console.ReadLine());

        analyzer.GetMonthlyBalance(month, year);
    }
}