// https://atcoder.jp/contests/abc040/tasks/abc040_a

let run n x =
    if x - 1 < n - x then
        x - 1
    else
        n - x

printfn "%i" (run 5 2)
//=> 1

printfn "%i" (run 6 4)
//=> 2

printfn "%i" (run 90 30)
//=> 29
