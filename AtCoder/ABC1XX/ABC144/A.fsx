// https://atcoder.jp/contests/abc144/tasks/abc144_a

let fn a b =
    if a > 9 || b > 9 then
        -1
    else
        a * b

printfn "%i" (fn 2 5)
//=> 10

printfn "%i" (fn 5 10)
//=> -1

printfn "%i" (fn 9 9)
//=> 81
