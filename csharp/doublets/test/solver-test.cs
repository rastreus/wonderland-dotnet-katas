namespace doublets;

using Xunit;
using static doublets.solver;

public class solver_test {
    [Fact]
    public void with_word_links_found() {
        Assert.Equal (
            new string[] { "head", "heal", "teal", "tell", "tall", "tail" },
            doublets("head", "tail")
        );
        Assert.Equal (
            new string[] { "door", "boor", "book", "look", "lock" },
            doublets("door", "lock")
        );
        Assert.Equal (
            new string[] { "bank", "bonk", "book", "look", "loon", "loan" },
            doublets("bank", "loan")
        );
        Assert.Equal (
            new string[] { "wheat", "cheat", "cheap", "cheep", "creep", "creed", "breed", "bread" },
            doublets("wheat", "bread")
        );
    }

    [Fact]
    public void with_no_word_links_found() {
        Assert.Equal (
            new string [] {},
            doublets("ye", "freezer")
        );
    }
}
