// https://atcoder.jp/contests/abc356/tasks/abc356_a

let fn n l r =
    Array.init n (fun i ->
        let x = i + 1
        if x >= l && x <= r then l + r - x else x)

printfn "%A" (fn 5 2 3)
//=> [| 1; 3; 2; 4; 5 |]

printfn "%A" (fn 7 1 1)
//=> [| 1; 2; 3; 4; 5; 6; 7 |]

printfn "%A" (fn 10 1 10)
//=> [| 10; 9; 8; 7; 6; 5; 4; 3; 2; 1 |]
