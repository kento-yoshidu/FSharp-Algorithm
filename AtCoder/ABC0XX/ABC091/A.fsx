// https://atcoder.jp/contests/abc091/tasks/abc091_a

let fn a b c =
    if a + b >= c then
        "Yes"
    else
        "No"

printfn "%s" (fn 50 100 120)
//=> Yes

printfn "%s" (fn 500 100 1000)
//=> No

printfn "%s" (fn 19 123 142)
//=> Yes
