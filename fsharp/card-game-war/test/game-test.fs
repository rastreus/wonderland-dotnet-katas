module game_test

open Expecto
open card_game_war.game

// fill in  tests for your game

[<Tests>]
let tests =
    testList "game" [
        testCase "the highest rank wins the cards in the round" <| fun _ ->
            Expect.equal
                0 1 ""
        testCase "queens are higher rank than jacks" <| fun _ -> ()
        testCase "kings are higher rank than queens" <| fun _ -> ()
        testCase "aces are higher rank than kings" <| fun _ -> ()

        testCase "the player loses when they run out of cards" <| fun _ -> ()
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
