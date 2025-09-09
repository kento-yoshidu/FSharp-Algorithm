// https://atcoder.jp/contests/abc096/tasks/abc096_a

let fn a b =
    if a <= b then
        a
    else
        if a = 1 then
            1
        else
            a - 1

printfn "%i" (fn 5 5)
//=> 5

printfn "%i" (fn 2 1)
//=> 1

printfn "%i" (fn 11 30)
//=> 11
