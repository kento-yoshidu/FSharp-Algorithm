// https://atcoder.jp/contests/abc413/tasks/abc413_a

let fn n m a =
    if a |> Array.sum <= m then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 15  [| 3; 1; 4; 1; 5 |])
//=> Yes

printfn "%s" (fn 5 5  [| 3; 1; 4; 1; 5 |])
//=> No

printfn "%s" (fn 1 10000  [| 100 |])
//=> Yes
