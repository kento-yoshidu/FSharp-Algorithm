// https://atcoder.jp/contests/abc213/tasks/abc213_b

let fn n (a: int array) =
    let dp = Array.create (n+1) 0

    dp.[0] <- 0
    dp.[1] <- abs(a.[1] - a.[0])

    for i in 2 .. n-1 do
        let v1 = dp.[i-1] + abs(a.[i] - a.[i-1])
        let v2 = dp.[i-2] + abs(a.[i] - a.[i-2])

        dp.[i] <- min v1 v2

    dp.[n-1]

printfn "%i" (fn 4 [| 10; 30; 40; 20 |])
//=> 30

printfn "%i" (fn 2 [| 10; 10 |])
//=> 0

printfn "%i" (fn 6 [| 30; 10; 60; 10; 60; 50 |])
//=> 40
