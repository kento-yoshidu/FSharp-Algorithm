// https://atcoder.jp/contests/abc412/tasks/abc412_a

let fn n ab =
    ab
    |> Array.filter (fun (a, b) -> a < b)
    |> Array.length

printfn "%i" (fn 4 [| (2, 8); (5, 5); (5, 4); (6, 7) |])
//=> 2

printfn "%i" (fn 5  [| (1, 1); (1, 1); (1, 1); (1, 1); (1, 1) |])
//=> 0

printfn "%i" (fn 6  [| (1, 6); (2, 5); (3, 4); (4, 3); (5, 2); (6, 1) |])
//=> 3
