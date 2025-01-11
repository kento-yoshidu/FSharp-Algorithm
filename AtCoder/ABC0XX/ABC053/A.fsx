// https://atcoder.jp/contests/abc053/tasks/abc053_a

let run x =
    if x < 1200 then
        "ABC"
    else
        "ARC"

printfn "%s" (run 1000)
//=> ABC

printfn "%s" (run 2000)
//=> ARC
