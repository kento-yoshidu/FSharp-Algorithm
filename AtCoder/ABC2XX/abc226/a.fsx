// https://atcoder.jp/contests/abc226/tasks/abc226_a

let fn (x: float) =
    int (System.Math.Round (x, 0))

printfn "%i" (fn 3.456)
//=> 3

printfn "%i" (fn 99.500)
//=> 100

printfn "%i" (fn 0.000)
//=> 0
