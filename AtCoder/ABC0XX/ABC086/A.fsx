// https://atcoder.jp/contests/abc086/tasks/abc086_a

let fn a b =
    if a * b % 2 = 0 then
        "Even"
    else
        "Odd"

printfn "%s" (fn 3 4)
//=> Even

printfn "%s" (fn 1 21)
//=> Odd
