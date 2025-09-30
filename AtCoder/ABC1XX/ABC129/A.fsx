// https://atcoder.jp/contests/abc129/tasks/abc129_a

let fn p q r =
    [p+q; p+r; q+r] |> List.min

printfn "%i" (fn 1 3 4)
//=> 4

printfn "%i" (fn 3 2 3)
//=> 5
