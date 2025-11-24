// https://atcoder.jp/contests/joi2026yo1b/tasks/joi2026_yo1b_d

let fn _n c =
    c
    |> Array.mapi (fun i num ->
        c
        |> Array.mapi (fun j num2 ->
            if num = num2 then abs (i - j) else 0)
        |> Array.sum)

printfn "%A" (fn 4 [| 1; 2; 1; 1 |])
//=> [|5; 0; 3; 4|]

printfn "%A" (fn 1 [| 100 |])
//=> [| 0 |]

printfn "%A" (fn 8 [| 1; 3; 9; 7; 3; 3; 7; 9 |])
//=> [| 0; 7; 5; 3; 4; 5; 3; 5 |]

printfn "%A" (fn 10 [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |])
//=> [| 45; 37; 31; 27; 25; 25; 27; 31; 37; 45 |]
