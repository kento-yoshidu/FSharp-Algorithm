// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_ab

let fn n =
    let mutable dp = Array.create (n+1) 0

    dp.[0] <- 1
    dp.[1] <- 1

    for i in 2..n do
        dp.[i] <- dp[i-1] + dp.[i-2]

    dp.[n]

printfn "%i" (fn 4)
//=> 5

printfn "%i" (fn 45)
//=> 1836311903
