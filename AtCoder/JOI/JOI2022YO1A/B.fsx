// https://atcoder.jp/contests/joi2022yo1a/tasks/joi2022_yo1a_b

let run x y z =
    if x + y <= z then
        1
    else
        0

printfn "%i" (run 2 3 4)
//=> 0

printfn "%i" (run 3 4 10)
//=> 1
