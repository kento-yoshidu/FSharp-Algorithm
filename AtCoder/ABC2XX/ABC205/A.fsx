// https://atcoder.jp/contests/abc205/tasks/abc205_a

let fn a b =
    float (a * b) / 100.0

printfn "%f" (fn 45 200)
//=> 90.000000

printfn "%f" (fn 37 450)
//=> 166.500000

printfn "%f" (fn 0 1000)
//=> 0.0

printfn "%f" (fn 50 0)
//=> 0.0
