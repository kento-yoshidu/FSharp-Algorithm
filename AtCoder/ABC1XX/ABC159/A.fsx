// https://atcoder.jp/contests/abc159/tasks/abc159_a

let fn n m =
    n * (n - 1) / 2 + m * (m - 1) / 2

printfn "%i" (fn 2 1)
//=> 1

printfn "%i" (fn 4 3)
//=> 9

printfn "%i" (fn 1 1)
//=> 0

printfn "%i" (fn 13 3)
//=> 81

printfn "%i" (fn 0 3)
//=> 3
