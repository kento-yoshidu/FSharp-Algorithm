// https://atcoder.jp/contests/abc094/tasks/abc094_a

let fn a b x =
    if a > x || a + b < x then
        "No"
    else
        "Yes"

printfn "%s" (fn 3 5 4)
//=> Yes

printfn "%s" (fn 2 2 6)
//=> No

printfn "%s" (fn 5 3 2)
//=> No
