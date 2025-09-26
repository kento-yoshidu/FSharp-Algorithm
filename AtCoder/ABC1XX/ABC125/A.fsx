// https://atcoder.jp/contests/abc125/tasks/abc125_a

let fn a b t =
    t / a * b

printfn "%i" (fn 3 5 7)
//=> 10

printfn "%i" (fn 3 2 9)
//=> 6

printfn "%i" (fn 20 20 19)
//=> 0

