module finder_test

open Expecto
open wonderland_number.finder

let hasAllTheSameDigits (n1 : int) (n2 : int) : bool =
    let s1 = n1 |> string |> Set.ofSeq
    let s2 = n2 |> string |> Set.ofSeq
    s1 = s2

[<Tests>]
let tests =
    testList "finder" [
        testCase "A wonderland number must have the following things true about it" <| fun _ ->
            let wondernum = wonderland_number()
            Expect.equal (wondernum |> string |> String.length) 6 ""
            Expect.isTrue (hasAllTheSameDigits wondernum (wondernum * 2)) ""
            Expect.isTrue (hasAllTheSameDigits wondernum (wondernum * 3)) ""
            Expect.isTrue (hasAllTheSameDigits wondernum (wondernum * 4)) ""
            Expect.isTrue (hasAllTheSameDigits wondernum (wondernum * 5)) ""
            Expect.isTrue (hasAllTheSameDigits wondernum (wondernum * 6)) ""
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
