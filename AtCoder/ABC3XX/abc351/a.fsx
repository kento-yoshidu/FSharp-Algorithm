// https://atcoder.jp/contests/abc351/tasks/abc351_a

let fn a b =
    let a = a |> Array.sum
    let b = b |> Array.sum

    a - b + 1

printfn "%i" (fn [| 0; 1; 0; 1; 2; 2; 0; 0; 1 |] [| 1; 1; 0; 0; 0; 0; 1; 0 |])
//=> 5

printfn "%i" (fn [| 0; 0; 0; 0; 0; 0; 0; 0; 0 |] [| 0; 0; 0; 0; 0; 0; 0; 0 |])
//=> 0
