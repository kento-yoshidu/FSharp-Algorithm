// https://atcoder.jp/contests/abc127/tasks/abc127_a

let fn a b =
    if a < 6 then
        0
    elif a < 13 then
        b / 2
    else
        b

printfn "%i" (fn 30 100)
//=> 100

printfn "%i" (fn 12 100)
//=> 50

printfn "%i" (fn 0 100)
//=> 0
