namespace fox_goose_bag_of_corn;

using System.Collections.Generic;

public class puzzle {

    public enum P {
        Fox,
        Goose,
        Corn,
        You,
        Boat
    }

    public static List<List<List<P>>> start_pos() =>
        new List<List<List<P>>>() {
            new List<List<P>>() {
                new List<P>() { P.Fox, P.Goose, P.Corn, P.You },
                new List<P>() { P.Boat },
                new List<P>() {}
            }
        };

    public static List<List<List<P>>> river_crossing_plan() =>
        start_pos();
}
