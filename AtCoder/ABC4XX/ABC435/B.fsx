// https://atcoder.jp/contests/abc435/tasks/abc435_b

let fn n a =
    let cumSum = a |> Array.scan (+) 0

    let sum l r = cumSum.[r+1] - cumSum.[l]

    let hasDivisor l r =
        let s = sum l r

        seq { l .. r }
        |> Seq.exists (fun k -> s % a.[k] = 0)

    let mutable ans = 0

    for i in 0..n-1 do
        for j in i+1..n-1 do
            if not (hasDivisor i j) then
                ans <- ans + 1

    ans

printfn "%i" (fn 5 [| 8; 6; 10; 5; 7 |])
//=> 6

printfn "%i" (fn 3 [| 1; 1; 1 |])
//=> 0
