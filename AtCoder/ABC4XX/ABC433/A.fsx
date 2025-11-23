// https://atcoder.jp/contests/abc433/tasks/abc433_a

let rec calc x y z =
    match y * z with
    | v when v > x -> "No"
    | v when x = x -> "Yes"
    | _ -> calc (x+1) (y+1) z

let fn x y z =
    calc x y z

printfn "%s" (fn 44 20 2)
//=> Yes

printfn "%s" (fn 28 10 3)
//=> No

printfn "%s" (fn 50 5 10)
//=> Yes

printfn "%s" (fn 1 100 2)
//=> No
