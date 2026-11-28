// https://atcoder.jp/contests/abc268/tasks/abc268_a

let fn a b c d e =
    [a; b; c; d; e]
    |> List.distinct
    |> List.length

printfn "%i" (fn 31 9 24 31 24)
//=> 3

printfn "%i" (fn 0 0 0 0 0)
//=> 1
