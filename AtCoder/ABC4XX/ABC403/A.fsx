// https://atcoder.jp/contests/abc403/tasks/abc403_a

let fn _n a =
    a
    |> Array.mapi (fun i n -> (i, n))
    |> Array.filter (fun (i, _) -> i % 2 = 0)
    |> Array.sumBy snd

printfn "%i" (fn 7 [| 3; 1; 4; 1; 5; 9; 2 |])
//=> 14

printfn "%i" (fn 1 [| 100 |])
//=> 100

printfn "%i" (fn 14 [| 100; 10; 1; 10; 100; 10; 1; 10; 100; 10; 1; 10; 100; 10 |])
//=> 403
