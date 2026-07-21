// https://atcoder.jp/contests/abc257/tasks/abc257_a

let fn n x =
    char (int 'A' + (x - 1) / n)

printfn "%c" (fn 1 3)
//=> C

printfn "%c" (fn 2 12)
//=> F
