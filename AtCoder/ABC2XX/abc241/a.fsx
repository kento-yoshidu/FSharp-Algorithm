// https://atcoder.jp/contests/abc241/tasks/abc241_a

let fn (a: int[]) =
    a.[a.[a.[0]]]

printfn "%i" (fn [| 9; 0; 1; 2; 3; 4; 5; 6; 7; 8 |])
//=> 7

printfn "%i" (fn [| 4; 8; 8; 8; 0; 8; 8; 8; 8; 8 |])
//=> 4

printfn "%i" (fn [| 0; 0; 0; 0; 0; 0; 0; 0; 0; 0 |])
//=> 0
