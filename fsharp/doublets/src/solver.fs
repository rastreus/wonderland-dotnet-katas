namespace doublets

module solver =

    let words =
        System.IO.File.ReadAllLines "./../resources/words.txt"

    let doublets (word1 : string) (word2 : string) : string list =
        [ "make me work" ]
