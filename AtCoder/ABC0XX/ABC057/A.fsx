// https://atcoder.jp/contests/abc057/tasks/abc057_a

let run a b =
    (a + b) % 24

printfn "%i" (run 9 12)
//=> 21

printfn "%i" (run 19 0)
//=> 19

printfn "%i" (run 23 2)
//=> 1
