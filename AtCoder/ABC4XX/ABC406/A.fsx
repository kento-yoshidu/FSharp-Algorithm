// https://atcoder.jp/contests/abc406/tasks/abc406_a

let fn a b c d =
    if a * 60 + b > c * 60 + d then
        "Yes"
    else
        "No"

printfn "%s" (fn 22 40 22 30)
//=> Yes

printfn "%s" (fn 22 40 22 45)
//=> No

printfn "%s" (fn 12 0 11 30)
//=> Yes
