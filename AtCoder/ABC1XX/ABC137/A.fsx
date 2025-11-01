// https://atcoder.jp/contests/abc137/tasks/abc137_a

let fn a b =
    max(max (a + b) (a - b)) (a * b)

printfn "%i" (fn -13 3)
//=> -10

printfn "%i" (fn 1 -33)
//=> 34

printf "%i" (fn 13 3)
//=> 39
