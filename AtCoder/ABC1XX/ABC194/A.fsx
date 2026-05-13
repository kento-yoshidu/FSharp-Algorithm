// https://atcoder.jp/contests/abc194/tasks/abc194_a

let fn a b =
    if a + b >= 15 && b >= 8 then
        1
    elif a + b >= 10 && b >= 3 then
        2
    elif a + b >= 3 then
        3
    else
        4

printfn "%i" (fn 10 8)
//=> 1

printfn "%i" (fn 1 2)
//=> 3

printfn "%i" (fn 0 0)
//=> 4
