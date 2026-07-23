// https://atcoder.jp/contests/abc340/tasks/abc340_a

let fn a b d =
    [| a..d..b |]

printfn "%A" (fn 3 9 2)
//=> [| 3; 5; 7; 9 |]

printfn "%A" (fn 10 10 1)
//=> [| 10 |]
