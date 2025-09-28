// https://atcoder.jp/contests/abc128/tasks/abc128_a

let fn a p =
    (a * 3 + p) / 2

printfn "%i" (fn 1 3)
//=> 3

printfn "%i" (fn 0 1)
//=> 0

printfn "%i" (fn 32 21)
//=> 58
