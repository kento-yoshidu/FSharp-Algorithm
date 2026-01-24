// https://atcoder.jp/contests/joi2026yo1a/tasks/joi2026_yo1a_c

let fn _n a b =
    Array.zip a b
    |> Array.collect (fun (x, y) -> [| x; y |])

printfn "%A" (fn 3 [| 3; 1; 4 |] [| 1; 5; 9 |])
//=> [|3; 1; 1; 5; 4; 9|]

printfn "%A" (fn 1 [| 2 |] [| 3 |])
//=> [|2; 3|]

printfn "%A" (fn 6 [| 12; 10; 8; 6; 4; 2 |] [| 11; 9; 7; 5; 3; 1 |])
//=> [|12; 11; 10; 9; 8; 7; 6; 5; 4; 3; 2; 1|]
