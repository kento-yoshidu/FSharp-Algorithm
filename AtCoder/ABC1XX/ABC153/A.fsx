// https://atcoder.jp/contests/abc153/tasks/abc153_a

let fn h a =
    (h + a - 1) / a

printfn "%i" (fn 10 4)
//=> 3

printfn "%i" (fn 1 10000)
//=> 1

printfn "%i" (fn 10000 1)
//=> 10000
