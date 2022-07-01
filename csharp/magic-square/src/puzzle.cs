namespace magic_square;

using System.Collections.Generic;

public class puzzle {

    public static List<double> values() =>
        new List<double>() { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0 };

    public static List<List<double>> magic_square (List<double> values) =>
        new List<List<double>>() {
            new List<double>() { 1.0, 1.5, 2.0 },
            new List<double>() { 2.5, 3.0, 3.5 },
            new List<double>() { 4.0, 4.5, 5.0 }
        };
}
