// https://atcoder.jp/contests/joi2021yo1b/tasks/joi2021_yo1b_a

let run a b c =
    if a <= c && c < b then
        1
    else
        0

printfn "%i" (run 2 5 3)
//=> 1

printfn "%i" (run 20 22 19)
//=> 0

printfn "%i" (run 24 30 30)
//=> 0

printfn "%i" (run 1 100 99)
//=> 1
