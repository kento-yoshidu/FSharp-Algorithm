// https://atcoder.jp/contests/abc165/tasks/abc165_a

let fn k a b =
    [| a .. b |]
    |> Array.exists (fun x -> x % k = 0)
    |> fun hasMultiple ->
        if hasMultiple then
            "OK"
        else
            "NG"

printfn "%s" (fn 7 500 600)
//=> OK

printfn "%s" (fn 4 5 7)
//=> NG

printfn "%s" (fn 1 11 11)
//=> OK
