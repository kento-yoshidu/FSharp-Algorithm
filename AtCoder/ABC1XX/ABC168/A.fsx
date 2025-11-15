// https://atcoder.jp/contests/abc168/tasks/abc168_a

let fn n =
    match n % 10 with
    | 2 | 4 | 5 | 7 | 9 -> "hon"
    | 0 | 1 | 6 | 8 -> "pon"
    | _ -> "bon"

printfn "%s" (fn 16)
//=> pon

printfn "%s" (fn 2)
//=> hon

printfn "%s" (fn 183)
//=> bon
