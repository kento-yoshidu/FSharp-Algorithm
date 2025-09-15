// https://atcoder.jp/contests/abc423/tasks/abc423_a

let fn x c =
    x / (1000 + c) * 1000

printfn "%i" (fn 650_000 8)
//=> 644000

printfn "%i" (fn 1003 4)
//=> 0

printfn "%i" (fn 10_000_000 24)
//=> 9_765_000
