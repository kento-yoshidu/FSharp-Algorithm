// https://atcoder.jp/contests/abc233/tasks/abc233_a

let fn x y =
    max ((y - x + 9) / 10) 0

printfn "%i" (fn 80 94)
//=> 2

printfn "%i" (fn 1000 63)
//=> 0

printfn "%i" (fn 270 750)
//=> 48
