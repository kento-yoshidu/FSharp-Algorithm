// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_t

let fn n (a: int array) =
    let mutable ans = 0

    for i in 0..n-1 do
        for j in i+1..n-1 do
            for k in j+1..n-1 do
                for l in k+1..n-1 do
                    for m in l+1..n-1 do
                        if a.[i] + a.[j] + a.[k] + a.[l] + a.[m] = 1000 then
                            ans <- ans + 1

    ans

printfn "%i" (fn 5 [| 100; 150; 200; 250; 300 |])
//=> 1

printfn "%i" (fn 13 [| 243; 156; 104; 280; 142; 286; 196; 132; 128; 195; 265; 300; 130 |])