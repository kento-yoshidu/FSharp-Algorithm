// https://atcoder.jp/contests/joi2022yo1a/tasks/joi2022_yo1a_c

let run _ s =
    let len = s |> Seq.distinct |> Seq.length

    if len >= 3 then
        "Yes"
    else
        "No"

printfn "%s" (run 4 "BABE")
//=> Yes

printfn "%s" (run 3 "DAD")
//=> No

printfn "%s" (run 5 "BACED")
//=> Yes

printfn "%s" (run 28 "EEEEEEEEEEEEEEEEEEEEEEEEEEEE")
//=> No
