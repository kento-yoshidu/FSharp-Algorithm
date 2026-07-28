// https://atcoder.jp/contests/abc468/tasks/abc468_a

let fn _n a =
    a
    |> Array.windowed 3
    |> Array.filter (fun arr ->
        arr.[0] < arr.[1] && arr.[1] > arr.[2])
    |> Array.length

printfn "%i" (fn 6 [| 3; 1; 4; 1; 5; 2 |])
//=> 2

printfn "%i" (fn 5 [| 1; 1; 1; 2; 1 |])
//=> 1

printfn "%i" (fn 10 [| 7; 3; 9; 8; 10; 3; 1; 5; 5; 4 |])
//=> 2
