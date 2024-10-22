namespace CardAndDeck;
public enum Suit{
    Hearts, Diamonds, Clubs, Spades
}
public enum Rank {
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen , King, Ace
}
public class Card {
    public Suit Suit {get;}
    public Rank Rank {get;}
    public Card(Suit suit, Rank rank){
        Suit = suit;
        Rank = rank;
    }
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}
public class Deck {
    private List<Card> _cards;
    private Random _random;
    public Deck(){
        _cards = new List<Card>();
        _random = new Random();
        foreach (Suit suit in Enum.GetValues(typeof(Suit))){
            foreach (Rank rank in Enum.GetValues(typeof(Rank))){
                _cards.Add(new Card(suit, rank));
            }
        }
        Shuffle();
        
    }
    public void Shuffle(){
        _cards = _cards.OrderBy(c=> _random.Next()).ToList();
    }
    public Card Deal () {
        if (_cards.Count == 0) return null;
        var card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }
    public int CardsLeft => _cards.Count;
}
