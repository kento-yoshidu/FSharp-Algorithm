// https://atcoder.jp/contests/abc210/tasks/abc210_a

let fn n a x y =
    min n a * x +  max 0 (n - a) * y

printfn "%i" (fn 5 3 20 15)
//=> 90

printfn "%i" (fn 10 10 100 1)
//=> 1000
