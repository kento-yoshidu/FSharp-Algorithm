// https://atcoder.jp/contests/abc103/tasks/abc103_a

let fn a b c =
    [a; b; c]
    |> List.sort
    |> Seq.pairwise
    |> Seq.map(fun (x, y) -> abs(x - y))
    |> Seq.sum

printfn "%i" (fn 1 6 3)
//=> 5

printfn "%i" (fn 11 5 5)
//=> 6

printfn "%i" (fn 100 100 100)
//=> 0
