// https://atcoder.jp/contests/abc152/tasks/abc152_a

let fn n m =
    if n = m then
        "Yes"
    else
        "No"

printfn "%s" (fn 3 3)
//=> Yes

printfn "%s" (fn 3 2)
//=> No

printfn "%s" (fn 1 1)
//=> Yes
