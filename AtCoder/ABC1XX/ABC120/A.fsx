// https://atcoder.jp/contests/abc120/tasks/abc120_a

let fn a b c =
    min c (b / a)

printfn "%i" (fn 2 11 4)
//=> 4

printfn "%i" (fn 3 9 5)
//=> 3

printfn "%i" (fn 100 1 10)
//=> 0
