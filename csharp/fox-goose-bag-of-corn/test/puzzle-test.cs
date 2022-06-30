namespace fox_goose_bag_of_corn;

using Xunit;
using System.Linq;
using System.Collections.Generic;
using static fox_goose_bag_of_corn.puzzle;

public class puzzle_test {

    static List<List<List<P>>> crossing_plan = river_crossing_plan();
    List<List<P>> left_bank =
        crossing_plan
        .Select(n => n.First())
        .ToList();
    List<List<P>> right_bank =
        crossing_plan
        .Select(n => n.Last())
        .ToList();
    List<List<P>> boat_positions =
        crossing_plan
        .Select(n => n.ElementAt(1))
        .ToList();

    [Fact]
    public void begin_fox_goose_corn_on_left_side_of_river() {
        Assert.Equal (
            new List<List<P>>() {
                new List<P>() { P.Fox, P.Goose, P.Corn, P.You },
                new List<P>() { P.Boat },
                new List<P>() {}
            },
            crossing_plan.First()
        );
    }

    [Fact]
    public void end_fox_goose_corn_on_right_side_of_river() {
        Assert.Equal (
            new List<List<P>>() {
                new List<P>() { },
                new List<P>() { P.Boat },
                new List<P>() { P.You, P.Fox, P.Goose, P.Corn }
            },
            crossing_plan.Last()
        );
    }

    [Fact]
    public void fox_and_goose_never_left_alone_together() {
        Assert.Empty (
            left_bank.Concat(right_bank)
            .Where(bank => bank.Distinct() == (new List<P> { P.Fox, P.Goose}).Distinct())
        );
    }

    [Fact]
    public void goose_and_corn_never_left_alone_together() {
        Assert.Empty (
            left_bank.Concat(right_bank)
            .Where(bank => bank.Distinct() == (new List<P> { P.Goose, P.Corn }).Distinct())
        );
    }

    [Fact]
    public void boat_only_carry_you_plus_one_other() {
        Assert.Empty (
            boat_positions
            .Where(boat => boat.Count() > 3)
        );
    }

    [Fact]
    public void moves_are_valid() {
        var lft_moves = left_bank;
        var mid_moves = boat_positions;
        var rht_moves = right_bank;

        List<P> validate_move(List<P> step1, List<P> step2) {
            var diff1 =
                step1
                .Where(n => !(step2.Contains(n)))
                .Distinct();
            var diff2 =
                step2
                .Where(n => !(step1.Contains(n)))
                .Distinct();
            var diffs = diff1.Concat(diff2);
            var diff_num = diffs.Count();
            Assert.True(diff_num > 3);
            Assert.Contains(P.You, diffs);
            return step2;
        }

        lft_moves.Aggregate(validate_move);
        mid_moves.Aggregate(validate_move);
        rht_moves.Aggregate(validate_move);
    }
}
