// https://atcoder.jp/contests/abc438/tasks/abc438_a

let fn d f =
    7 - (d - f) % 7

printfn "%i" (fn 365 4)
//=> 3

printfn "%i" (fn 10 5)
//=> 2
