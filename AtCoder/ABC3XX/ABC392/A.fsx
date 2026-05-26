// https://atcoder.jp/contests/abc392/tasks/abc392_a

let fn a1 a2 a3 =
    match [| a1; a2; a3|] |> Array.sort with
    | [| x; y; z |] when x * y = z -> "Yes"
    | _ -> "No"

printfn "%s" (fn 3 15 5)
//=> Yes

printfn "%s" (fn 5 3 2)
//=> No

printfn "%s" (fn 3 3 9)
//=> No
