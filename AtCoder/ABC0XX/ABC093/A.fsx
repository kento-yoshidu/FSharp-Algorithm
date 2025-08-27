// https://atcoder.jp/contests/abc093/tasks/abc093_a

let fn s =
    let str =
        s
        |> Seq.sort
        |> Seq.map string
        |> String.concat ""

    if str = "abc" then
        "Yes"
    else
        "No"

printfn "%s" (fn "bac")
//=> Yes

printfn "%s" (fn "bab")
//=> No

printfn "%s" (fn "abc")
//=> Yes

printfn "%s" (fn "aaa")
//=> No
