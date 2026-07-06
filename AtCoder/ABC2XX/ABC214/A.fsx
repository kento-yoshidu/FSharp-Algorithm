// https://atcoder.jp/contests/abc214/tasks/abc214_a

let fn n =
    if 1 <= n && n <= 125 then
        4
    elif 126 <= n && n <= 211 then
        6
    else
        8

printfn "%i" (fn 214)
//=> 8

printfn "%i" (fn 1)
//=> 4

printfn "%i" (fn 126)
//=> 6
