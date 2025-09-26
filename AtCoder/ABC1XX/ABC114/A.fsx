// https://atcoder.jp/contests/abc114/tasks/abc114_a

let fn x =
    if x = 3 || x = 5 || x = 7 then
        "YES"
    else
        "NO"

printfn "%s" (fn 5)
//=> YES

printfn "%s" (fn 6)
//=> 6
