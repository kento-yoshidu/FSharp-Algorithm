// https://atcoder.jp/contests/abc203/tasks/abc203_a

let fn a b c =
    if a <> b && b <> c && a <> c then
        0
    else
        a ^^^ b ^^^ c

printfn "%i" (fn 2 5 2)
//=> 5

printfn "%i" (fn 4 5 6)
//=> 0

printfn "%i" (fn 1 1 1)
//=> 1
