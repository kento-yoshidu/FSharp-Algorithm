// https://atcoder.jp/contests/abc465/tasks/abc465_a

let fn a b =
    if a > b * 2.0 / 3.0 then
        "Yes"
    else
        "No"

printfn "%s" (fn 316 465)
//=> Yes

printfn "%s" (fn 101 248)
//=> No

printfn "%s" (fn 666 999)
//=> No
