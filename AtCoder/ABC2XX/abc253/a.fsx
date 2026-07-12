// https://atcoder.jp/contests/abc253/tasks/abc253_a

let fn a b c =
    let sorted = [a; b; c] |> List.sort

    if sorted.[1] = b then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 3 2)
//=> Yes

printfn "%s" (fn 2 5 3)
//=> No

printfn "%s" (fn 100 100 100)
//=> Yes
