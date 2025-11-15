// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_w

let fn n b r =
    Seq.zip b r
    |> Seq.map (fun (a, b) ->
        float a / float n + float b / float n )
    |> Seq.sum

printfn "%f" (fn 3 [| 1; 2; 3 |] [| 10; 20; 30 |])
//=> 22.000000
