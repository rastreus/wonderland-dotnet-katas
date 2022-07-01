namespace magic_square;

using Xunit;
using System.Linq;
using System.Collections.Generic;
using static magic_square.puzzle;

public class puzzle_test {

    private double sum_rows(List<List<double>> m) =>
        m
        .Select(x => x.Sum())
        .Sum();

    private double sum_cols(List<List<double>> m) =>
        sum_rows (
            new List<List<double>>() {
                new List<double>(m.Select(x => x.First())),
                new List<double>(m.Select(x => x.ElementAt(1))),
                new List<double>(m.Select(x => x.Last()))
            }
        );

    private double sum_diagonals(List<List<double>> m) =>
        (m.ElementAt(0).ElementAt(0))
        + (m.ElementAt(1).ElementAt(1))
        + (m.ElementAt(2).ElementAt(2))
        + (m.ElementAt(2).ElementAt(0))
        + (m.ElementAt(1).ElementAt(1))
        + (m.ElementAt(0).ElementAt(2));

    [Fact]
    public void all_rows_cols_diag_add_to_same_number() {
        double rows = sum_rows(magic_square(values()));
        double cols = sum_cols(magic_square(values()));
        double diag = sum_diagonals(magic_square(values()));
        Assert.True(rows == cols);
        Assert.True(rows == diag);
        Assert.True(cols == diag);
    }
}
