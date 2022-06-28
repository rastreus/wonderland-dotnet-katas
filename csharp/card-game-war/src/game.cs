namespace card_game_war;

using System.Collections.Generic;

public class game {

    public enum Suit {
        Spade,
        Club,
        Diamond,
        Heart
    }

    public enum Rank {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack,
        Queen,
        King,
        Ace
    }

    public readonly record struct Card(Suit suit, Rank rank);

    /*
    public static List<Card> deck() {
        List<Card> deck = new();
        foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
            foreach (Rank rank in Enum.GetValues(typeof(Rank))) {
                deck.Add(new Card(suit, rank));
            }
        }
        return deck;
    }
    */

    public static void playRound (Card player1_card, Card player2_card) =>
        throw new System.NotImplementedException();

    public static void playGame (List<Card> player1_cards, List<Card> player2_cards) =>
        throw new System.NotImplementedException();
}
