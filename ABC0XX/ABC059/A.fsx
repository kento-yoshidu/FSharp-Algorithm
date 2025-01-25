// https://atcoder.jp/contests/abc059/tasks/abc059_a

open System

let toUpper (s: string) =
    String(Char.ToUpper(s.[0]), 1)

let run a b c =
    toUpper(a) + toUpper(b) + toUpper(c)

printfn "%s" (run "atcoder" "beginner" "contest")
//=> ABC

printfn "%s" (run "resident" "register" "number")
//=> RRN

printfn "%s" (run "k" "nearest" "neighbor")
//=> KNN

printfn "%s" (run "async" "layered" "coding")
//=> ALC
