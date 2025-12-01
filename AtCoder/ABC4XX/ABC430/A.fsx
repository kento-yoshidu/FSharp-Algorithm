// https://atcoder.jp/contests/abc430/tasks/abc430_a

let fn a b c d =
    if c >= a && d < b then
        "Yes"
    else
        "No"

printfn "%s" (fn 10 20 30 40)
//=> No

printfn "%s" (fn 10 20 30 4)
//=> Yes

printfn "%s" (fn 100 100 1 1)
//=> No
