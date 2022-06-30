namespace doublets;

public class solver {

    public static string[] words() =>
        System.IO.File.ReadAllLines("./../resources/words.txt");

    public static string[] doublets(string word1, string word2) =>
        new string[] { "make me work" };
}
