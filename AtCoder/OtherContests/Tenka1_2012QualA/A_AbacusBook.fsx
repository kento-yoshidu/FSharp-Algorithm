// https://atcoder.jp/contests/tenka1-2012-qualA/tasks/tenka1_2012_qualA_1

open System

let run n =
    if n = 0 then 1
    else
        let dp = Collections.Generic.List<int>()
        dp.Add(1)
        dp.Add(1)

        for i in 2..n do
            dp.Add(dp.[i-1] + dp[i-2])

        dp.[n]

printfn "%i" (run 0)
//=> 1

printfn "%i" (run 5)
//=> 8

printfn "%i" (run 45)
//=> 1836311903
