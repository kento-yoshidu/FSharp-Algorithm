// https://atcoder.jp/contests/abc185/tasks/abc185_a

let fn a =
    Array.min a

printfn "%i" (fn [| 5; 3; 7; 11 |])
//=> 3

printfn "%i" (fn [| 100; 100; 1; 100 |])
//=> 1
