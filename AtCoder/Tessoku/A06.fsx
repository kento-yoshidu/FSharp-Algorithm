// https://atcoder.jp/contests/tessoku-book/tasks/math_and_algorithm_ai

let fn _n _q a lr =
    let cumsum = a |> Array.scan (+) 0

    lr |> Array.map (fun (l, r) -> cumsum.[r] - cumsum[l-1])

printfn "%A" (fn 10 5 [| 8; 6; 9; 1; 2; 1; 10; 100; 1000; 10000 |] [| (2, 3); (1, 4); (3, 9); (6, 8); (1, 10); |])
