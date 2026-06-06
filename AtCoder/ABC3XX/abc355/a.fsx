// https://atcoder.jp/contests/abc355/tasks/abc355_a

let fn a b =
    if a = b then
        -1
    else
        a ^^^ b

printfn "%i" (fn 1 2)
//=> 3

printfn "%i" (fn 1 1)
//=> -1

printfn "%i" (fn 3 1)
//=> 2
