// https://atcoder.jp/contests/abc170/tasks/abc170_a

let fn x1 x2 x3 x4 x5 =
    [| x1; x2; x3; x4; x5 |]
    |> Array.findIndex (fun n -> n = 0)
    |> fun i -> i + 1

printfn "%i" (fn 0 2 3 4 5)
//=> 1

printfn "%i" (fn 1 2 0 4 5)
//=> 3
