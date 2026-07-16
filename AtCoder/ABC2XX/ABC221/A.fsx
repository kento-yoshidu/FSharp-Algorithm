// https://atcoder.jp/contests/abc221/tasks/abc221_a

let fn a b =
    pown 32 (a - b)

printfn "%i" (fn 6 4)
//=> 1024

printfn "%i" (fn 5 5)
//=> 1
