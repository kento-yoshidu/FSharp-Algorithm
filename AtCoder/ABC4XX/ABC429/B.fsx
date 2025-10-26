// https://atcoder.jp/contests/abc429/tasks/abc429_b

let fn n m a =
    let sum = a |> List.sum

    if a |> List.contains (sum - m) then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 10 [3; 2; 3; 4])
//=> Yes

printfn "%s" (fn 5 16 [3; 3; 4; 2; 5])
//=> No

printfn "%s" (fn 6 16 [0; 8; 0; 2; 6; 8])
//=> Yes
