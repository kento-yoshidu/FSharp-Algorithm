// https://atcoder.jp/contests/abc037/tasks/abc037_a

let run a b c =
    if a < b then
        c / a
    else
        c / b

printfn "%i" (run 3 5 6)
//=> 2

printfn "%i" (run 8 6 20)
//=> 3
