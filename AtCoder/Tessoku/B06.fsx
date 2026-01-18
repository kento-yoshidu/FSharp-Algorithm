// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_ce

let fn _n a  _q lr =
    let cumsum =
        a |> Array.scan (fun sum x -> if x = 1 then sum + 1 else sum - 1) 0

    lr
    |> Array.map (fun (l, r) ->
        let x = cumsum.[r] - cumsum.[l-1]

        if x >= 1 then
            "win"
        elif x = 0 then
            "draw"
        else "lose")

printfn "%A" (fn 7 [| 0; 1; 1; 0; 1; 0; 0 |] 3 [| (2, 5); (2, 7); (5, 7) |])
