
class BankStatementAnalyser
{
    public List<BankStatement> Transactions { get; set; } = new List<BankStatement>();
    public decimal NetBalance { get; set; }

    public void LoadTransactions(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                var date = DateTime.ParseExact(values[0], "dd-MM-yyyy", null);
                var amount = decimal.Parse(values[1]);
                var description = values[2];

                var transaction = new BankStatement
                {
                    Date = date,
                    Amount = amount,
                    Description = description
                };

                Transactions.Add(transaction);
                NetBalance += amount;
            }
        }
    }

    public void GetTransactions()
    {
        foreach (var transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }
        Console.WriteLine($"Net Balance: {NetBalance}");
    }

    public void GetMonthlyBalance(int month, int year)
    {
        decimal monthlyBalance = 0;
        foreach (var transaction in Transactions)
        {
            if (transaction.Date.Month == month && transaction.Date.Year == year)
            {
                monthlyBalance += transaction.Amount;
            }   
        }
        Console.WriteLine($"Monthly Balance: {monthlyBalance}" );
    }
}
