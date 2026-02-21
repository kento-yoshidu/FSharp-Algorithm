// https://atcoder.jp/contests/abc435/tasks/abc435_a

let fn n =
    [| 1 .. n |]
    |> Array.fold (fun acc x -> acc + x) 0

printfn "%i" (fn 5)
//=> 15

printfn "%i" (fn 1)
//=> 1

printfn "%i" (fn 29)
//=> 435
