// https://atcoder.jp/contests/abc046/tasks/abc046_a

let run a b c =
    [a; b; c]
    |> List.distinct
    |> List.length

printfn "%i" (run 3 1 4)
//=> 3

printfn "%i" (run 3 3 33)
//=> 2
