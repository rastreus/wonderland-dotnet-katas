module puzzle_test

open Expecto
open fox_goose_bag_of_corn.puzzle

[<Tests>]
let tests =
    let crossing_plan = river_crossing_plan()
    let left_bank =
        crossing_plan
        |> List.map (fun steps -> steps |> List.head)
    let right_bank =
        crossing_plan
        |> List.map (fun steps -> steps |> List.last)
    let boat_positions =
        crossing_plan
        |> List.map (fun steps -> steps |> List.item 1)
    testList "puzzle" [
        testCase "you begin with the fox, goose and corn on one side of the river" <| fun _ ->
            Expect.containsAll (crossing_plan |> List.head) ([[Fox; Goose; Corn; You]; [Boat]; []]) ""

        testCase "you end with the fox, goose and corn on one side of the river" <| fun _ ->
            Expect.containsAll (crossing_plan |> List.last) ([[]; [Boat]; [You; Fox; Goose; Corn]]) ""

        testCase "the fox and the goose should never be left alone together" <| fun _ ->
            Expect.isEmpty
                ((left_bank @ right_bank)
                |> List.filter (fun bank -> (bank |> Set.ofList) = ([Fox; Goose] |> Set.ofList))) ""

        testCase "the goose and the corn should never be left alone together" <| fun _ ->
            Expect.isEmpty
                ((left_bank @ right_bank)
                |> List.filter (fun bank -> (bank |> Set.ofList) = ([Goose; Corn] |> Set.ofList))) ""

        testCase "the boat can carry only you plus one other" <| fun _ ->
            Expect.isEmpty
                (boat_positions |> List.filter (fun boat -> boat.Length > 3)) ""

        testCase "moves are valid" <| fun _ ->
            let lft_moves = left_bank
            let mid_moves = boat_positions
            let rht_moves = right_bank

            let validate_move (step1 : Puzzle list) (step2 : Puzzle list) =
                let diff1 =
                    step1
                    |> List.filter (fun n -> not (step2 |> List.contains n))
                    |> List.distinct
                let diff2 =
                    step2
                    |> List.filter (fun n -> not (step1 |> List.contains n))
                    |> List.distinct
                let diffs = diff1 @ diff2
                let diff_num = diffs |> List.length
                Expect.isGreaterThan 3 diff_num ""
                Expect.contains diffs You ""
                step2

            lft_moves |> List.reduce validate_move |> ignore
            mid_moves |> List.reduce validate_move |> ignore
            rht_moves |> List.reduce validate_move |> ignore
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
