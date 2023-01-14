class BankStatement
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Transaction {{ Date = {Date.ToShortDateString()}, Amount = {Amount}, Description = {Description} }}";
    }
}
