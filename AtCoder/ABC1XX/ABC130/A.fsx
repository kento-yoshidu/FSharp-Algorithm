// https://atcoder.jp/contests/abc130/tasks/abc130_a

let fn x a =
    if x < a then
        0
    else
        10

printfn "%i" (fn 3 5)
//=> 0

printfn "%i" (fn 7 5)
//=> 10

printfn "%i" (fn 6 6)
//=> 10
