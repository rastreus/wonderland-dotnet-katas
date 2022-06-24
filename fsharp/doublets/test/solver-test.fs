module solver_test

open Expecto
open doublets.solver

[<Tests>]
let tests =
    testList "solver" [
        testCase "with word links found" <| fun _ ->
            Expect.equal
                (doublets "head" "tail") ["head"; "heal"; "teal"; "tell"; "tall"; "tail"] ""
            Expect.equal
                (doublets "door" "lock") ["door"; "boor"; "book"; "look"; "lock"] ""
            Expect.equal
                (doublets "bank" "loan") ["bank"; "bonk"; "book"; "look"; "loon"; "loan"] ""
            Expect.equal
                (doublets "wheat" "bread") ["wheat"; "cheat"; "cheap"; "cheep"; "creep"; "creed"; "breed"; "bread"] ""

        testCase "with no word links found" <| fun _ ->
            Expect.equal
                (doublets "ye" "freezer") [] ""
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
