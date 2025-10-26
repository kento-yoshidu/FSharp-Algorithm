// https://atcoder.jp/contests/abc131/tasks/abc131_a

open System

let fn (s: string) =
    let chars = s.ToCharArray()

    let res =
        chars
        |> Array.pairwise
        |> Array.exists (fun (a, b) -> a = b)

    if res then
        "Bad"
    else
        "Good"


printfn "%s" (fn "3776")
//=> YES

printfn "%s" (fn "8080")
//=> Good

printfn "%s" (fn "1333")
//=> Bad

printfn "%s" (fn "0024")
//=> Bad
