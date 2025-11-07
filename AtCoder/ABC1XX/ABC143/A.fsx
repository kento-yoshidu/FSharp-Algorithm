// https://atcoder.jp/contests/abc143/tasks/abc143_a

let fn a b =
    max 0 (a - b * 2)

printfn "%i" (fn 12 4)
//=> 4

printfn "%i" (fn 20 15)
//=> 0

printfn "%i" (fn 20 30)
//=> 0
