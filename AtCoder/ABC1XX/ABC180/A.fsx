// https://atcoder.jp/contests/abc180/tasks/abc180_a

let fn n a b =
    n - a + b

printfn "%i" (fn 100 1 2)
//=> 101

printfn "%i" (fn 100 2 1)
//=> 99

printfn "%i" (fn 100 1 1)
//=> 100
