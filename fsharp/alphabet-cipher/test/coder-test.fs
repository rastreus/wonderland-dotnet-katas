module coder_test

open Expecto
open alphabet_cipher.coder

[<Tests>]
let tests =
    testList "coder" [
        testCase "can encode a message with a secret keyword" <| fun _ ->
            Expect.equal
                (encode "vigilance" "meetmeontuesdayeveningatseven") "hmkbxebpxpmyllyrxiiqtoltfgzzv" ""
            Expect.equal
                (encode "scones" "meetmebythetree") "egsgqwtahuiljgs" ""

        testCase "can decode a message given an encoded message and a secret keyword" <| fun _ ->
            Expect.equal
                (decode "vigilance" "hmkbxebpxpmyllyrxiiqtoltfgzzv") "meetmeontuesdayeveningatseven" ""
            Expect.equal
                (decode "scones" "egsgqwtahuiljgs") "meetmebythetree" ""

        testCase "can extract the secret keyword given an encrypted message and the original message" <| fun _ ->
            Expect.equal
                (decipher "opkyfipmfmwcvqoklyhxywgeecpvhelzg" "thequickbrownfoxjumpsoveralazydog") "vigilance" ""
            Expect.equal
                (decipher "hcqxqqtqljmlzhwiivgbsapaiwcenmyu" "packmyboxwithfivedozenliquorjugs") "scones" ""
            Expect.equal
                (decipher "hfnlphoontutufa" "hellofromrussia") "abcabcx" ""
    ]

[<EntryPoint>]
let main argv =
    runTestsInAssembly defaultConfig argv
