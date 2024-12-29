// https://atcoder.jp/contests/abc386/tasks/abc386_a

let run a b c d =
    let list =
        [a; b; c; d]
        |> List.sort
        |> List.distinct

    if List.length list = 2 then
        "Yes"
    else
        "No"

printfn "%s" (run 7 7 7 1)
//=> Yes

printfn "%s" (run 13 12 11 10)
//=> No

printfn "%s" (run 3 3 5 5)
//=> Yes

printfn "%s" (run 8 8 8 8)
//=> No

printfn "%s" (run 1 3 4 1)
//=> No
