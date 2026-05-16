// https://atcoder.jp/contests/abc232/tasks/abc232_a

let toInt c = int c - int '0'

let fn (s: string) =
    toInt s.[0] * toInt s.[2]

printfn "%i" (fn "3x7")
//=> 21

printfn "%i" (fn "9x9")
//=> 81

printfn "%i" (fn "1x1")
//=> 1
