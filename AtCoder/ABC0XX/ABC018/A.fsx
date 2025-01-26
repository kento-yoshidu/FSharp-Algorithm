// https://atcoder.jp/contests/abc018/tasks/abc018_1

let run a b c =
    let list = [(a, 1); (b, 2); (c, 3)]

    list
    |> List.sortByDescending fst
    |> List.map snd

printfn "%A" (run 12 18 11)
//=> [2; 1; 3]

printfn "%A" (run 10 20 30)
//=> [3; 2; 1]
