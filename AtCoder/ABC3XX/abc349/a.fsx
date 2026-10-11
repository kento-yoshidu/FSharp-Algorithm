// https://atcoder.jp/contests/abc349/tasks/abc349_a

let fn n a =
    a
    |> Array.map(fun n -> -n)
    |> Array.sum

printfn "%i" (fn 4 [| 1; -2; -1 |])
//=> 2

printfn "%i" (fn 3 [| 0; 0 |])
//=> 0

printfn "%i" (fn 6 [| 10; 20; 30; 40; 50 |])
//=> -150
