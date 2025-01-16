// https://atcoder.jp/contests/abc066/tasks/abc066_a

let run (a: int) (b: int) (c: int) =
    [a; b; c]
    |> List.sort
    |> fun sorted -> sorted.[0] + sorted.[1]

printfn "%i" (run 700 600 780)
//=> 1300

printfn "%i" (run 10000 10000 10000)
//=> 20000
