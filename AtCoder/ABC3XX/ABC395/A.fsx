// https://atcoder.jp/contests/abc395/tasks/abc395_a

let fn _n a =
    if a
        |> Array.pairwise
        |> Array.forall (fun (a, b) -> a < b) then
        "Yes"
    else
        "No"

printfn "%s" (fn 3 [| 1; 2; 5 |])
//=> Yes

printfn "%s" (fn 3 [| 3; 9; 5 |])
//=> No

printfn "%s" (fn 10 [| 1; 1; 2; 3; 5; 8; 13; 21; 34; 55 |])
//=> No
