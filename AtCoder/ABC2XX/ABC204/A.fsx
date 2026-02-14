// https://atcoder.jp/contests/abc204/tasks/abc204_a

let fn x y =
    (6 - x - y) % 3

printfn "%i" (fn 0 1)
//=> 2

printfn "%i" (fn 0 0)
//=> 0
