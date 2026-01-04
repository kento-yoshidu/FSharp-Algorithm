// https://atcoder.jp/contests/abc439/tasks/abc439_a

let fn n =
    pown 2 n - 2 * n

printfn "%i" (fn 1)
//=> 0

printfn "%i" (fn 2)
//=> 0

printfn "%i" (fn 11)
//=> 2026
