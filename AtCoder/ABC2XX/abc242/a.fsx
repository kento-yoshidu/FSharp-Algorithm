// https://atcoder.jp/contests/abc242/tasks/abc242_a

let fn a b c x =
    if x <= a then
        1.0
    elif b < x then
        0.0
    else
        float c / float (b - a)

printfn "%f" (fn 30 500 20 103)
//=> 0.042553

printfn "%f" (fn 50 500 100 1)
//=> 1.0

printfn "%f" (fn 1 2 1 1000)
//=> 0.0
