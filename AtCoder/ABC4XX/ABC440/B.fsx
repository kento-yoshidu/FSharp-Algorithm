// https://atcoder.jp/contests/abc440/tasks/abc440_b

let fn _n t =
    t
    |> Array.indexed
    |> Array.sortBy snd
    |> Array.take 3
    |> Array.map (fun (i, _) -> i+1)

printfn "%A" (fn 4 [| 100; 110; 105; 95 |])
//=> [| 4; 1; 3 |]

printfn "%A" (fn 8 [| 72; 74; 69; 70; 73; 75; 71; 77 |])
//=> [| 3; 4; 7 |]
