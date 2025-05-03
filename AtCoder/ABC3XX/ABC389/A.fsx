// https://atcoder.jp/contests/abc389/tasks/abc389_a

let run (s: string) =
    (int s.[0] - int '0') * (int s.[2] - int '0')

printfn "%i" (run "8x3")
//=> 24

printfn "%i" (run "9x9")
//=> 81
