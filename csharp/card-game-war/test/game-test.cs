namespace card_game_war;

using Xunit;
using static card_game_war.game;

public class game_test {
    [Fact]
    public void highest_rank_wins_cards_in_round() {
        Assert.Equal (
            0, 1
        );
    }

    [Fact]
    public void queens_higher_rank_than_jacks() {}

    [Fact]
    public void kings_higher_rank_than_queens() {}

    [Fact]
    public void aces_higher_rank_than_kings() {}

    [Fact]
    public void player_loses_when_out_of_cards() {}
}
