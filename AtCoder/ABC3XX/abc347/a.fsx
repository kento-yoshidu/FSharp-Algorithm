// https://atcoder.jp/contests/abc347/tasks/abc347_a

let fn n k a =
    a
    |> Array.filter (fun i -> i % k = 0)
    |> Array.map (fun i -> i / k)

printfn "%A" (fn 5 2 [| 2; 5; 6; 7; 10 |])
//=> [| 1; 3; 5 |]

printfn "%A" (fn 3 1 [| 3; 4; 7 |])
//=> [| 3; 4; 7 |]

printfn "%A" (fn 5 10 [| 50; 51; 54; 60; 65 |])
//=> [| 5; 6 |]
