// https://atcoder.jp/contests/abc211/tasks/abc211_a

let fn a b =
    (a - b) / 3.0 + b

printfn "%f" (fn 130 100)
//=> 110.0

printfn "%f" (fn 300 50)
//=> 133.333333

printfn "%f" (fn 123 123)
//=> 123.0
