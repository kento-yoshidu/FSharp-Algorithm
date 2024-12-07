// https://atcoder.jp/contests/abc027/tasks/abc027_a

let run a b c =
    [|a; b; c|]
    |> Array.groupBy(fun x -> x)
    |> Array.tryFind(fun (_, group) -> group.Length = 1)
    |> Option.map fst
    |> Option.defaultValue a

printfn "%i" (run 1 1 2)
//=> 3

printfn "%i" (run 4 3 4)
//=> 3

printfn "%i" (run 5 5 5)
//=> 5
