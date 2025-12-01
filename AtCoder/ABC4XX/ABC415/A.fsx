// https://atcoder.jp/contests/abc415/tasks/abc415_a

let fn n a x =
    if Array.contains x a then
        "Yes"
    else
        "No"

printfn "%s" (fn 5  [| 3; 1; 4; 1; 5 |] 4)
//=> Yes

printfn "%s" (fn 4 [| 100; 100; 100; 100 |] 100)
//=> Yes

printfn "%s" (fn 6 [| 2; 3; 5; 7; 11; 13 |] 1)
//=> No
