// https://atcoder.jp/contests/abc387/tasks/abc387_a

let run a b =
    (a + b) * (a + b)

printfn "%i" (run 20 25)
//=> 2025

printfn "%i" (run 30 25)
//=> 3035

printfn "%i" (run 45 11)
//=> 3136

printfn "%i" (run 2025 1111)
//=> 9834496
