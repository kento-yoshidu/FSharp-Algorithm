// https://atcoder.jp/contests/abc432/tasks/abc432_a

let fn a b c =
    let sorted = List.sort [a; b; c] |> List.rev

    sorted.[0] * 100 + sorted.[1] * 10 + sorted.[2]

printfn "%i" (fn 3 2 4)
//=> 432

printfn "%i" (fn 7 7 7)
//=> 777

printfn "%i" (fn 9 1 9)
//=> 991
