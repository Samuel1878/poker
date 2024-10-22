using CardAndDeck;
using GameLogic;
using Players;
class Program {
    public static void Main (string[] args){
        Console.WriteLine("Welcome to multiplayer poker!");
        var playerNames = new List<string> {
            "Samuel", "Alice", "Charlie"
        };
        var game = new PokerGame(playerNames);
        game.DealCards(2);
        game.ShowHands();
    }
}
