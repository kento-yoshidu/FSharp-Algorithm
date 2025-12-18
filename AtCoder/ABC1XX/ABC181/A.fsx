// https://atcoder.jp/contests/abc181/tasks/abc181_a

let fn n =
    if n % 2 = 0 then
        "White"
    else
        "Black"

printfn "%s" (fn 2)
//=> White

printfn "%s" (fn 5)
//=> Black
