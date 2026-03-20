// https://atcoder.jp/contests/abc377/tasks/abc377_a

let fn s =
    let sorted =
        s
        |> Seq.sort
        |> Seq.map string
        |> String.concat ""

    if sorted = "ABC" then
        "Yes"
    else
        "No"

printfn "%s" (fn "BAC")
//=> Yes

printfn "%s" (fn "AAC")
//=> No

printfn "%s" (fn "ABC")
//=> Yes

printfn "%s" (fn "ARC")
//=> No
