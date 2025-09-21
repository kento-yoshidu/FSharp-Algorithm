// https://atcoder.jp/contests/abc122/tasks/abc122_a

let fn c =
    match c with
    | 'A' -> 'T'
    | 'T' -> 'A'
    | 'G' -> 'C'
    | _ -> 'G'

printfn "%c" (fn 'A')
//=> T

printfn "%c" (fn 'G')
//=> C
