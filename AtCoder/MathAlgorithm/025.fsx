// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_y

let fn _n a b =
    Array.zip a b
    |> Array.sumBy (fun (a, b) ->
        (float a + float b * 2.0) / 3.0)

printfn "%f" (fn 5 [| 3; 1; 4; 1; 5 |] [| 9; 2; 6; 5; 3 |])
//=> 21.333333
