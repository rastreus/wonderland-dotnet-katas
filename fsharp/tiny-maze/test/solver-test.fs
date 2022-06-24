module solver_test

open Expecto
open tiny_maze.solver

[<Tests>]
let tests =
    testList "solver" [
        testCase "can find way to exit with 3x3 maze" <| fun _ ->
            let maze =
                [ [    S; V(0); V(1) ]
                  [ V(1); V(0); V(1) ]
                  [ V(1); V(0);    E ] ]
            let sol =
                [ [    X; X; V(1) ]
                  [ V(1); X; V(1) ]
                  [ V(1); X;    X ] ]
            Expect.equal
                (solve_maze maze) sol ""

        testCase "can find way to exit with 4x4 maze" <| fun _ ->
            let maze =
                [ [    S; V(0); V(0); V(1) ]
                  [ V(1); V(1); V(0); V(0) ]
                  [ V(1); V(0); V(0); V(1) ]
                  [ V(1); V(1); V(0);    E ] ]
            let sol =
                [ [    X;    X; X; V(1) ]
                  [ V(1); V(1); X; V(0) ]
                  [ V(1); V(0); X; V(1) ]
                  [ V(1); V(1); X;    X ] ]
            Expect.equal
                (solve_maze maze) sol ""
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
