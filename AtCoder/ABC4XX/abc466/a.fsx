// https://atcoder.jp/contests/abc466/tasks/abc466_a

let fn n x =
    if x |> Array.forall (fun x -> x < 0) then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 [| 2; 0; -1; 2 |])
//=> No

printfn "%s" (fn 3 [| -5; -2; -1 |])
//=> Yes

printfn "%s" (fn 4 [| 0; -2; 0; -1 |])
//=> No
