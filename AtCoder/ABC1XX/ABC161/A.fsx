// https://atcoder.jp/contests/abc161/tasks/abc161_a

let fn x y z =
    (z, x, y)

printfn "%A" (fn 1 2 3)
//=> (3, 1, 2)

printfn "%A" (fn 100 100 100)
//=> (100, 100, 100)

printfn "%A" (fn 41 59 31)
//=> (31, 41, 59)
