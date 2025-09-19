// https://atcoder.jp/contests/abc110/tasks/abc110_a

let fn a b c =
    let sorted =
        [a; b; c]
        |> List.sort
        |> List.rev

    sorted.[0] * 10 + sorted.[1] + sorted[2]

printfn "%i" (fn 1 5 2)
//=> 53

printfn "%i" (fn 9 9 9)
//=> 108

printfn "%i" (fn 6 6 7)
//=> 82
