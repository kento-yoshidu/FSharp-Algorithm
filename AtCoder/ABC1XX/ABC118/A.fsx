// https://atcoder.jp/contests/abc118/tasks/abc118_a

let fn a b =
    if b % a = 0 then
        a + b
    else
        b - a

printfn "%i" (fn 4 12)
//=> 16

printfn "%i" (fn 8 20)
//=> 12

printfn "%i" (fn 1 1)
//=> 2
