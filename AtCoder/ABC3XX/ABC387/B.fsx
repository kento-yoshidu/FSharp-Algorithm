// https://atcoder.jp/contests/abc387/tasks/abc387_b

let run x =
    [1..9]
    |> List.collect (fun i -> [1..9] |> List.map (fun j -> i*j))
    |> List.filter (fun num -> num <> x)
    |> List.sum

printfn "%i" (run 1)
//=> 2024

printfn "%i" (run 11)
//=> 2025

printfn "%i" (run 24)
//=> 1929
