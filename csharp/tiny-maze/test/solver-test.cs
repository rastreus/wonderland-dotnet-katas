namespace tiny_maze;

using Xunit;
using System.Collections.Generic;
using static tiny_maze.solver;

public class solver_test {
    [Fact]
    public void can_exit_3x3_maze() {
        var maze =
            new List<List<P>>() {
                new List<P>() { P.S, P.O, P.W },
                new List<P>() { P.W, P.O, P.W },
                new List<P>() { P.W, P.O, P.E }
            };
        var sol =
            new List<List<P>>() {
                new List<P>() { P.X, P.X, P.W },
                new List<P>() { P.W, P.X, P.W },
                new List<P>() { P.W, P.X, P.X }
            };
        Assert.Equal (sol, solve_maze(maze));
    }

    [Fact]
    public void can_exit_4x4_maze() {
        var maze =
            new List<List<P>>() {
                new List<P>() { P.S, P.O, P.O, P.W },
                new List<P>() { P.W, P.W, P.O, P.O },
                new List<P>() { P.W, P.O, P.O, P.W },
                new List<P>() { P.W, P.W, P.O, P.E },
            };
        var sol =
            new List<List<P>>() {
                new List<P>() { P.X, P.X, P.X, P.W },
                new List<P>() { P.W, P.X, P.X, P.O },
                new List<P>() { P.W, P.O, P.X, P.W },
                new List<P>() { P.W, P.W, P.X, P.X },
            };
        Assert.Equal (sol, solve_maze(maze));
    }
}
