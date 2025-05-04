// https://atcoder.jp/contests/abc080/tasks/abc080_a

let fn n a b =
    min b (n * a)

printfn "%i" (fn 7 17 120)
//=> 119

printfn "%i" (fn 5 20 100)
//=> 100

printfn "%i" (fn 6 18 100)
//=> 100
