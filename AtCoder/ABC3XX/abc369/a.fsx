// https://atcoder.jp/contests/abc369/tasks/abc369_a

let fn a b =
    if a = b then
        1
    elif abs(b - a) % 2 = 0 then
        3
    else
        2

printfn "%i" (fn 5 7)
//=> 3

printfn "%i" (fn 6 1)
//=> 2

printfn "%i" (fn 3 3)
//=> 1
