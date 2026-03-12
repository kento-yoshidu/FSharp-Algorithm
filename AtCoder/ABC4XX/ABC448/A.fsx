// https://atcoder.jp/contests/abc448/tasks/abc448_a

let fn _n x a =
    let (_, ans) =
        Array.fold
            (fun (cur, res) num ->
                if num < cur then
                    (num, 1 :: res)
                else
                    (cur, 0 :: res))
            (x, [])
            a
    List.rev ans

printfn "%A" (fn 5 10 [| 6; 4; 7; 1; 3 |])
//=> [1; 1; 0; 1; 0]

printfn "%A" (fn 1 1 [| 1 |])
//=> [1]

printfn "%A" (fn 8 20 [| 9; 19; 14; 17; 17; 4; 18; 4 |])
//=> [1; 0; 0; 0; 0; 1; 0; 0]
