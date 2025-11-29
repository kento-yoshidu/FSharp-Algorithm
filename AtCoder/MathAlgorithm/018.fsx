// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_r

let fn n a =
    let count = Array.create 401 0

    a |> Array.iter (fun x ->
        count.[x] <- count.[x] + 1)

    count.[100] * count.[400] + count.[200] * count.[300]

printfn "%i" (fn 5 [| 100; 300; 400; 400; 200 |])
//=> 3
