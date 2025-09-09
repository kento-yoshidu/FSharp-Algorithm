// https://atcoder.jp/contests/abc097/tasks/abc097_a

let fn a b c d =
    if abs(c - a) <= d then
        "Yes"
    else
        if abs(b - a) <= d && abs(c - b) <= d then
            "Yes"
        else
            "No"

printfn "%s" (fn 4 7 9 3)
//=> Yes

printfn "%s" (fn 100 10 1 2)
//=> No

printfn "%s" (fn 10 10 10 1)
//=> Yes

printfn "%s" (fn 1 100 2 10)
//=> Yes
