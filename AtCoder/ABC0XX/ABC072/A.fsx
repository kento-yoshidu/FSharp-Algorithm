// https://atcoder.jp/contests/abc072/tasks/abc072_a

let run x t =
    max(x - t) 0

printfn "%i" (run 100 17)
//=> 83

printfn "%i" (run 48 58)
//=> 0

printfn "%i" (run 1000000000 1000000000)
//=> 0
