// https://atcoder.jp/contests/abc368/tasks/abc368_a

let fn n k (a: int[]) =
    Array.append a.[n-k..] a.[0..n-k-1]

printfn "%A" (fn 5 3 [| 1; 2; 3; 4; 5 |])
//=> 

printfn "%A" (fn 6 2 [| 1; 2; 1; 2; 1; 2 |])
//=> 
