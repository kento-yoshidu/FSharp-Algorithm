// https://atcoder.jp/contests/abc052/tasks/abc052_a

let run a b c d=
    max (a*b) (c*d)

printfn "%i" (run 3 5 2 7)
//=> 15

printfn "%i" (run 100 600 200 300)
//= 60000
