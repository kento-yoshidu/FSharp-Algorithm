// https://atcoder.jp/contests/abc014/tasks/abc014_1

let run a b =
    if a % b = 0 then
        0
    else
        b - (a % b)

printfn "%i" (run 7 3)
//=> 2

printfn "%i" (run 5 5)
//=> 0

printfn "%i" (run 1 100)
//=> 99

printfn "%i" (run 25 12)
//=> 11
