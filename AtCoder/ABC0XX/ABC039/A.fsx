// https://atcoder.jp/contests/abc039/tasks/abc039_a

let run a b c =
    2 * (a*b + b*c + a*c)

printfn "%i" (run 2 3 4)
//=> 52

printfn "%i" (run 3 4 2)
//=> 52

printfn "%i" (run 100 100 100)
//=> 60000
