// https://atcoder.jp/contests/abc346/tasks/abc346_a

let fn n a =
    a
    |> Array.pairwise
    |> Array.map (fun (a, b) -> a * b)

printfn "%A" (fn 3 [| 3; 4; 6 |])
//=> [| 12; 24 |]

printfn "%A" (fn 5 [| 22; 75; 26; 45; 72 |])
//=> [| 1650; 1950; 1170; 3240 |]
