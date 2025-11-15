// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_x

let fn _n pq =
    Array.fold (fun acc (p, q) -> acc + (float q) / (float p)) 0.0 pq

printfn "%f" (fn 2 [| (2, 50); (4, 100) |])
//=> 50.0
