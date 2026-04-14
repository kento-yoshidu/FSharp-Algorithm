
// https://atcoder.jp/contests/abc405/tasks/abc405_a

let fn r x =
    match x, r with
    | 1, r when 1600 <= r && r <= 2999 -> "Yes"
    | 2, r when 1200 <= r && r <= 2399 -> "Yes"
    | 1, _
    | 2, _ -> "No"
    | _ -> failwith "unreachable"

printfn "%s" (fn 2000 1)
//=> Yes

printfn "%s" (fn 1000 1)
//=> No

printfn "%s" (fn 1500 2)
//=> Yes

printfn "%s" (fn 2800 2)
//=> No
