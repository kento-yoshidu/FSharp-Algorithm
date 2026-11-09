// https://atcoder.jp/contests/abc259/tasks/abc259_a

let fn n m x t d =
    if x <= m then
        t
    else
        t - (x - m) * d

printfn "%i" (fn 38 20 17 168 3)
//=> 168

printfn "%i" (fn 1 0 1 3 2)
//=> 1

printfn "%i" (fn 100 10 100 180 1)
//=> 90
