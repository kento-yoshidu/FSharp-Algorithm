// https://atcoder.jp/contests/abc133/tasks/abc133_a

let fn n a b =
    min b (n * a)

printfn "%i" (fn 4 2 9)
//=> 8

printfn "%i" (fn 4 2 7)
//=> 7

printfn "%i" (fn 4 2 8)
//=> 8
