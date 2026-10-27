// https://atcoder.jp/contests/abc343/tasks/abc343_a

let fn a b =
    [0..9]
    |> List.find (fun c -> c <> a + b)

printfn "%i" (fn 2 5)
//=> 0

printfn "%i" (fn 0 0)
//=> 1

printfn "%i" (fn 7 1)
//=> 0
