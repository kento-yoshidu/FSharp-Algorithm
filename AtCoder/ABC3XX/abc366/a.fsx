// https://atcoder.jp/contests/abc366/tasks/abc366_a

let fn n t a =
    let temp = (n + 1) / 2
    if temp <= t || temp <= a then
        "Yes"
    else
        "No"

printfn "%s" (fn 7 4 2)
//=> Yes

printfn "%s" (fn 99 12 48)
//=> No

printfn "%s" (fn 1 0 0)
//=> No
