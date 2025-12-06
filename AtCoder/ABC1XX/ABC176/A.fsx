// https://atcoder.jp/contests/abc176/tasks/abc176_a

let fn n x t =
    (n + x - 1) / x * t

printfn "%i" (fn 20 12 6)
//=> 12

printfn "%i" (fn 1000 1 1000)
//=> 1000000
