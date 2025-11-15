// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_z

let fn n =
    [| 1 .. n |]
    |> Array.sumBy (fun i -> 1.0 * float n / float i)

printfn "%f" (fn 5)
//=> 11.416667
