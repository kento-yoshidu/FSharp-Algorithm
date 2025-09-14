// https://atcoder.jp/contests/abc115/tasks/abc115_a

let fn s =
    match s with
    | 25 -> "Christmas"
    | 24 -> "Christmas Eve"
    | 23 -> "Christmas Eve Eve"
    | 22 -> "Christmas Eve Eve Eve"
    | _ -> "unreachable"

printfn "%s" (fn 25)
//=> Christmas

printfn "%s" (fn 22)
//=> Christmas Eve Eve Eve
