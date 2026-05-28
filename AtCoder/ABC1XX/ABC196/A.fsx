// https://atcoder.jp/contests/abc196/tasks/abc196_a

let fn a b c d =
    max a b - min c d

printfn "%i" (fn 0 10 0 10)
//=> 10

printfn "%i" (fn -100 -100 100 100)
//=> -200

printfn "%i" (fn -100 100 -100 100)
//=> 200
