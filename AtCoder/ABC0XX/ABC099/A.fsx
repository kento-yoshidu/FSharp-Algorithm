// https://atcoder.jp/contests/abc099/tasks/abc099_a

let fn n =
    if n < 1000 then
        "ABC"
    else
        "ABD"

printfn "%s" (fn 999)
//=> ABC

printfn "%s" (fn 1000)
//=> ABD

printfn "%s"(fn 1481)
//=> ABD
