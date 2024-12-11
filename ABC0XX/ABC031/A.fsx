// https://atcoder.jp/contests/abc031/tasks/abc031_a

let run a d =
    if a > d then
        a * (d + 1)
    else
        d * (a + 1)

printfn "%i" (run 31 87)
//=> 2784

printfn "%i" (run 101 65)
//=> 6666

printfn "%i" (run 3 3)
//=> 12
