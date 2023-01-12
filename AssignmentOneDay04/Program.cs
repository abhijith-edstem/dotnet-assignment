// French Deck


class Program
{
    static void Main()
    {

        FrenchDeck deck = new FrenchDeck();

        Console.WriteLine("Original Deck:");
        deck.PrintDeck();

        Console.WriteLine("Shuffled Deck:");
        deck.Shuffle();
        deck.PrintDeck();

        Console.WriteLine("Random Card:");
        Card randomCard = deck.PickRandomCard();
        randomCard.PrintCard();
    }
}