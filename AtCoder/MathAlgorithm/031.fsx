// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_ac

let fn n (a: int array) =
    let mutable dp = Array.create n 0

    dp.[0] <- a.[0]
    dp.[1] <- max a.[0] a.[1]

    for i in 2..n-1 do
        dp.[i] <- max dp.[i-1] (dp.[i-2] + a.[i])

    dp.[n-1]

printfn "%i" (fn 5 [| 2; 5; 3; 3; 1 |])
//=> 8
