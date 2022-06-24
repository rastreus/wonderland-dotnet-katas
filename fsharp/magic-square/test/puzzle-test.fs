module puzzle_test

open Expecto
open magic_square.puzzle

let sum_rows (m : List<float list>) : float =
    m
    |> List.map (fun x -> x |> List.reduce (+))
    |> List.sum

let sum_cols (m : List<float list>) : float =
    [
        m |> List.map (fun x -> x |> List.head)
        m |> List.map (fun x -> x |> List.item 1)
        m |> List.map (fun x -> x |> List.last)
    ]
    |> sum_rows

let sum_diagonals (m : List<float list>) : float =
    ((m |> List.item 0) |> List.item 0)
    + ((m |> List.item 1) |> List.item 1)
    + ((m |> List.item 2) |> List.item 2)
    + ((m |> List.item 2) |> List.item 0)
    + ((m |> List.item 1) |> List.item 1)
    + ((m |> List.item 0) |> List.item 2)

[<Tests>]
let tests =
    testList "puzzle" [
        testCase "all the rows, columns, and diagonal add to the same number" <| fun _ ->
            let rows = values |> magic_square |> sum_rows
            let cols = values |> magic_square |> sum_cols
            let diag = values |> magic_square |> sum_diagonals
            Expect.isTrue (rows = cols) ""
            Expect.isTrue (rows = diag) ""
            Expect.isTrue (cols = diag) ""
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
