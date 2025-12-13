// https://atcoder.jp/contests/abc425/tasks/abc425_a

let fn n =
    [| 0 .. n |]
    |> Array.map (fun i -> (pown -1 i) * pown i 3)
    |> Array.sum

printfn "%i" (fn 3)
//=> -20

printfn "%i" (fn 9)
//=> -425

printfn "%i" (fn 10)
//=> 575
