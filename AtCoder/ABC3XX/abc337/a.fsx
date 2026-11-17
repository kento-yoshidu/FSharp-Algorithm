// https://atcoder.jp/contests/abc337/tasks/abc337_a

let fn _n (xy: (int * int) array) =
    let x = xy |> Array.sumBy fst
    let y = xy |> Array.sumBy snd

    if x > y then
        "Takahashi"
    elif x < y then
        "Aoki"
    else
        "Draw"

printfn "%s" (fn 3 [| (10, 2); (10, 1); (10, 2) |])
//=> Takahashi

printfn "%s" (fn 6 [| (5, 4); (4, 5); (2, 4); (1, 6); (7, 1); (3, 2) |])
//=> Draw

printfn "%s" (fn 4 [| (0, 0); (10, 10); (50, 50); (0, 100) |])
//=> Aoki
