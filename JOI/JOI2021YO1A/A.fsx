// https://atcoder.jp/contests/joi2021yo1a/tasks/joi2021_yo1a_a

let run a b c =
    [a; b; c]
    |> List.sort
    |> List.item 1

printfn "%i" (run 7 5 3)
//=> 5

printfn "%i" (run 1 3 3)
//=> 3

printfn "%i" (run 100 100 100)
//=> 100

printfn "%i" (run 29 83 1)
//=> 29
