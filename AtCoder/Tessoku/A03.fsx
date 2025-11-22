// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_c

let fn n k p q =
    if p
        |> Array.exists ( fun x ->
            q
            |> Array.exists (fun y -> x + y = k)) then
            "Yes"
        else
            "No"

printfn "%s" (fn 3 100 [| 17; 57; 99 |] [| 10; 36; 53 |])
//=> No

printfn "%s" (fn 5 53 [| 10; 20; 30; 40; 50 |] [| 1; 2; 3; 4; 5 |])
//=> Yes
