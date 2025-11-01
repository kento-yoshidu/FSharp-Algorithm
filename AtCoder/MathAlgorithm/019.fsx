// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_s

let fn _n a =
    let count = Array.create 4 0

    a |> Array.iter(fun x ->
        count.[x] <- count.[x] + 1)

    let a = count.[1] * (count.[1] - 1) / 2
    let b = count.[2] * (count.[2] - 1) / 2
    let c = count.[3] * (count.[3] - 1) / 2

    a + b + c

printfn "%i" (fn 6 [| 1; 3; 2; 1; 1; 2 |])
//=> 4
