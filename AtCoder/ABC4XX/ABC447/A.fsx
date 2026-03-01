// https://atcoder.jp/contests/abc447/tasks/abc447_a

let fn n m =
    if (n + 1) / 2 >= m then
        "Yes"
    else
        "No"

printfn "%s" (fn 6 3)
//=> Yes

printfn "%s" (fn 4 3)
//=> No

printfn "%s" (fn 5 3)
//=> Yes

printfn "%s" (fn 44 7)
//=> Yes
