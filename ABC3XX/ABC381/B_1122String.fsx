// https://atcoder.jp/contests/abc381/tasks/abc381_a

open System
open System.Collections.Generic

let run (s: string) =
    let chars = s.ToCharArray()

    let isValidPairs =
        [| for i in 0 .. 2 .. chars.Length - 2 -> chars.[i], chars.[i + 1] |]
        |> Array.forall (fun (a, b) -> a = b)

    if not isValidPairs then
        "No"
    else
        let count = Dictionary<char, int>()

        for c in chars do
            if count.ContainsKey(c) then
                count.[c] <- count.[c]+1
            else
                count.[c] <- 1

        if count.Values |> Seq.forall (fun v -> v = 2) then
            "Yes"
        else
            "No"


printfn "%s" (run "aabbcc")
//=> Yes

printfn "%s" (run "aab")
//=> Yes

printfn "%s" (run "zzzzzz")
//=> No
