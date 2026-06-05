// https://atcoder.jp/contests/abc238/tasks/abc238_a

let fn n =
    if 2 <= n && n <= 4 then
        "No"
    else
        "Yes"

printfn "%s" (fn 5)
//=> Yes

printfn "%s" (fn 2)
//=> No

printfn "%s" (fn 623947744)
//=> Yes
