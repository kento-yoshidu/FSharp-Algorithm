// https://atcoder.jp/contests/abc061/tasks/abc061_a

let run a b c =
    if a <= c && c <= b then
        "Yes"
    else
        "No"

printfn "%s" (run 1 3 2)
//=> Yes

printfn "%s" (run 6 5 4)
//=> No

printfn "%s" (run 2 2 2)
//=> Yes
