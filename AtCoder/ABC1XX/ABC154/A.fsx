// https://atcoder.jp/contests/abc154/tasks/abc154_a

let fn s t a b u =
    match u with
    | c when c = s -> (a-1, b)
    | _ -> (a, b-1)

printfn "%A" (fn "red" "blue" 3 4 "red")
//=> (2, 4)

printfn "%A" (fn "red" "blue" 5 5 "blue")
//=> (5, 4)
