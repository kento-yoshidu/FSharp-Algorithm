// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_v

let fn n a =
    let count = Array.create 100_001 0

    for num in a do
        count.[num] <- count.[num] + 1

    let mutable ans = 0;

    for i in 0..49_999 do
        let j = 100_000 - i

        ans <- ans + count.[i] * count.[j]

    ans <- ans + count.[50_000] * (count.[50_000] - 1) / 2

    ans

printfn "%i" (fn 6 [| 40000; 50000; 20000; 80000; 50000; 30000 |])
//=> 2
