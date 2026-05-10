// https://atcoder.jp/contests/abc396/tasks/abc396_a

let fn _n a =
    if a
        |> Array.windowed 3
        |> Array.exists (fun a -> a.[0] = a.[1] && a.[0] = a.[2]) then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 [| 1; 4; 4; 4; 2 |])
//=> Yes

printfn "%s" (fn 6 [| 2; 4; 4; 2; 2; 4 |])
//=> No

printfn "%s" (fn 8 [| 1; 4; 2; 5; 7; 7; 7; 2 |])
//=> Yes

printfn "%s" (fn 10 [| 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 |])
//=> No

printfn "%s" (fn 13 [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |])
//=> Yes
