// https://atcoder.jp/contests/joi2026yo1b/tasks/joi2026_yo1b_b

let fn x y z =
    if min x y <= z then
        1
    else
        0

printfn "%i" (fn 3 5 3)
//=> 1

printfn "%i" (fn 10 20 1)
//=> 0

printfn "%i" (fn 3 5 3)
//=> 1

printfn "%i" (fn 1 1 10)
//=> 1
