// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_j

let fn n =
    [1 .. n]
    |> List.fold (fun acc x -> acc * x) 1

printfn "%i" (fn 5)
//=> 120
