// https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_b

let fn n x a =
    if Array.contains x a then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 40 [| 10; 20; 30; 40; 50 |])
//=> Yes

printfn "%s" (fn 6 28 [| 30; 10; 40; 10; 50; 90 |])
//=> No
