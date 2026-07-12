// https://atcoder.jp/contests/abc220/tasks/abc220_a

let fn a b c =
    let arr = [| a .. b |]
    let isM x = x % c = 0

    match Array.tryFind isM arr with
    | Some v -> v
    | None -> -1

printfn "%i" (fn 123 456 100)
//=> 200

printfn "%i" (fn 630 940 314)
//=> -1
