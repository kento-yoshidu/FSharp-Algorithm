// https://atcoder.jp/contests/abc255/tasks/abc255_a

let fn r c (a: int[]) (b: int[]) =
    let arr = [| a; b |]
    arr.[r-1][c-1]

printfn "%i" (fn 1 2 [| 1; 0 |] [| 0; 1 |])
//=> 0

printfn "%i" (fn 2 2 [| 1; 2 |] [| 3; 4 |])
//=> 4

printfn "%i" (fn 2 1 [| 90; 80 |] [| 70; 60 |])
//=> 70
