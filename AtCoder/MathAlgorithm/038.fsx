// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_ai

let fn n q a lr =
    let cumSum =
        a
        |> Array.fold
            (fun (acc: int list) x ->
                let last = List.head acc
                (last + x) :: acc)
            [0]
        |> List.rev
        |> List.toArray

    lr |> Array.map (fun (l, r) -> cumSum.[r] - cumSum.[l-1])


printfn "%A" (fn 10 5 [| 8; 6; 9; 1; 2; 1; 10; 100; 1000; 10000 |] [| (2, 3); (1, 4); (3, 9); (6, 8); (1, 10) |])