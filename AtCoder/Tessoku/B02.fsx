// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_ca

let fn a b =
    if [| a .. b |] |> Array.exists (fun i -> 100 % i = 0) then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 20)
//=> Yes

printfn "%s" (fn 6 9)
//=> No
