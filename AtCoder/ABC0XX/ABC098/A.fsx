// https://atcoder.jp/contests/abc098/tasks/abc098_a

let fn a b =
    List.max [a + b; a * b; a - b]

printfn "%i" (fn 3 1)
//=> 4

printfn "%i" (fn 4 -2)
//=> 6

printfn "%i" (fn 0 0)
//=> 0
