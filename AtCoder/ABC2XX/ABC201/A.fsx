// https://atcoder.jp/contests/abc201/tasks/abc201_a

let fn a1 a2 a3 =
    let a = [| a1; a2; a3 |] |> Array.sort

    if a.[1] - a.[0] = a.[2] - a.[1] then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 1 3)
//=> Yes

printfn "%s" (fn 1 4 3)
//=> No

printfn "%s" (fn 5 5 5)
//=> Yes
