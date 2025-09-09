// https://atcoder.jp/contests/abc031/tasks/abc031_a

let fn s =
    s
    |> Seq.toList
    |> List.sumBy(fun c -> if c = '+' then 1 else -1)

printfn "%i" (fn "+-++")
//=> 2

printfn "%i" (fn "-+--")
//=> -2

printfn "%i" (fn "----")
//=> -4
