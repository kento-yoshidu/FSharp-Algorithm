// https://atcoder.jp/contests/abc376/tasks/abc376_a

let fn _n c (t: int[]) =
    let init = (1, t[0])  // (ans, cur)

    t
    |> Array.skip 1
    |> Array.fold (fun (ans, cur) x ->
        if x - cur >= c then
            (ans + 1, x)
        else
            (ans, cur)
    ) init
    |> fst

printfn "%i" (fn 6 5 [| 1; 3; 7; 8; 10; 12 |])
//=> 3

printfn "%i" (fn 3 2 [| 0; 2; 4 |])
//=> 3

printfn "%i" (fn 10 3 [| 0; 3; 4; 6; 9; 12; 15; 17; 19; 20 |])
//=> 7
