using CardAndDeck;
using Players;
namespace GameLogic;
public class PokerGame {
    private Deck _deck;
    private List<Player> _players;
    public PokerGame(List<string> playerNames){
        _deck = new Deck();
        _players = playerNames.Select(name=> new Player(name)).ToList();

    }
    public void DealCards (int cardsPerPlayer){
        for (int i = 0; i < cardsPerPlayer; i++){
            foreach (var player in _players){
                player.ReceiveCard(_deck.Deal());
            }
        }
    }
    public void ShowHands () {
        foreach(var player in _players){
            Console.WriteLine(player);
        }
    }
}