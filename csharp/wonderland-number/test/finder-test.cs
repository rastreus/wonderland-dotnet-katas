namespace wonderland_number;

using Xunit;
using System.Collections.Generic;
using static wonderland_number.finder;

public class finder_test {

    private bool hasAllTheSameDigits(int n1, int n2) {
        var s1 = new HashSet<char>(n1.ToString().ToCharArray());
        var s2 = new HashSet<char>(n2.ToString().ToCharArray());
        return (s1 == s2);
    }

    [Fact]
    public void wonderland_number_must_have_the_following() {
        int wondernum = wonderland_number();
        Assert.Equal(6, wondernum.ToString().Length);
        Assert.True(hasAllTheSameDigits(wondernum, (wondernum * 2)));
        Assert.True(hasAllTheSameDigits(wondernum, (wondernum * 3)));
        Assert.True(hasAllTheSameDigits(wondernum, (wondernum * 4)));
        Assert.True(hasAllTheSameDigits(wondernum, (wondernum * 5)));
        Assert.True(hasAllTheSameDigits(wondernum, (wondernum * 6)));
    }
}
