// https://atcoder.jp/contests/abc462/tasks/abc462_a

open System

let fn (s: string) =
    s
        |> Seq.filter Char.IsDigit
        |> Array.ofSeq
        |> String

printfn "%s" (fn "abc462")
//=> 462

printfn "%s" (fn "codequeen")
//=>

printfn "%s" (fn "31415")
//=> 31415

printfn "%s" (fn "10plus2is12")
//=> 10212
