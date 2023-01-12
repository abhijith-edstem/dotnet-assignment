class FrenchDeck
{
    public List<Card> Cards { get; set; }
    public FrenchDeck()
    {
        Cards = new List<Card>();
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string[] suits = { "spades", "diamonds", "clubs", "hearts" };

        foreach (string rank in ranks)
        {
            foreach (string suit in suits)
            {
                Cards.Add(new Card(rank, suit));
            }
        }
    }

    public void Shuffle()
    {
        Random rand = new Random();
        for (int i = 0; i < Cards.Count; i++)
        {
            int randomIndex = rand.Next(i, Cards.Count);
            Card temp = Cards[i];
            Cards[i] = Cards[randomIndex];
            Cards[randomIndex] = temp;
        }
    }

    public void PrintDeck()
    {
        foreach (Card card in Cards)
        {
            card.PrintCard();
        }
    }

    public Card PickRandomCard()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0, Cards.Count);
        return Cards[randomIndex];
    }

}

