// https://atcoder.jp/contests/abc074/tasks/abc074_a

let run n a =
    n * n - a

printfn "%i" (run 3 4)
//=> 5

printfn "%i" (run 19 100)
//=> 261

printfn "%i" (run 10 0)
//=> 100
