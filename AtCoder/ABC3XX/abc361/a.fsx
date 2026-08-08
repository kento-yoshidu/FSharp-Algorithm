// https://atcoder.jp/contests/abc361/tasks/abc361_a

let fn n k x (a: int[]) =
    Array.concat [
        a.[0..k-1]
        [| x |]
        a.[k..n-1]]

printfn "%A" (fn 4 3 7 [| 2; 3; 5; 11 |])
//=> [|2; 3; 5; 7; 11|]

printfn "%A" (fn 1 1 100 [| 100 |])
//=> [|100; 100|]

printfn "%A" (fn 8 8 3 [| 9; 9; 8; 2; 4; 4; 3; 5 |])
//=> [|9; 9; 8; 2; 4; 4; 3; 5; 3|]
