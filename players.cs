using CardAndDeck;

namespace Players;
public class Player 
{
    public string Name {get;}
    public List<Card> Hand {get; private set;}
    public Player(string name){
        Name = name;
        Hand = new List<Card>();
    }
    public void ReceiveCard(Card card){
        Hand.Add(card);
    }
    public void ClearHand(){
        Hand.Clear();
    }
    public override string ToString()
    {
        return $"{Name}:  {string.Join(", ", Hand)}";
    }
}