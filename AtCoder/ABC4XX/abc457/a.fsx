// https://atcoder.jp/contests/abc457/tasks/abc457_a

let fn _n (a: int[]) x =
    a.[x - 1]

printfn "%i" (fn 5 [| 1; 2; 3; 4; 5 |] 3)
//=> 3

printfn "%i" (fn 10 [| 6; 6; 9; 6; 10; 5; 7; 2; 8; 2 |] 4)
//=> 6

printfn "%i" (fn 10 [| 4; 4; 4; 3; 4; 2; 1; 1; 2; 1 |] 10)
//=> 1
