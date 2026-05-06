// https://atcoder.jp/contests/abc397/tasks/abc397_a

let fn x =
    if x >= 38.0 then
        1
    elif x >= 37.5 then
        2
    else
        3

printfn "%i" (fn 40.0)
//=> 1

printfn "%i" (fn 37.7)
//=> 2

printfn "%i" (fn 36.6)
//=> 3
