// https://atcoder.jp/contests/abc408/tasks/abc408_a

let fn _n s (t: int[]) =
    if t.[0] > s then
        "No"
    elif
        t
        |> Array.windowed 2
        |> Array.exists (fun w -> abs (w.[1] - w.[0]) > s)
    then
        "No"
    else
        "Yes"

printfn "%s" (fn 5 10 [| 6; 11; 21; 22; 30 |])
//=> Yes

printfn "%s" (fn 2 100 [| 1; 200 |])
//=> No

printfn "%s" (fn 10 22 [| 47; 81; 82; 95; 117; 146; 165; 209; 212; 215 |])
//=> No
