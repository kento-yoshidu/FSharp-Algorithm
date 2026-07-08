// https://atcoder.jp/contests/abc216/tasks/abc216_a

let fn (x: float) =
    let integerPart = int x
    let decimalPart = int (x * 10.0) % 10

    match decimalPart with
    | 0 | 1 | 2 -> sprintf "%d-" integerPart
    | 3 | 4 | 5 | 6 -> string integerPart
    | 7 | 8 | 9 -> sprintf "%d+" integerPart
    | _ -> failwith "unreachable"

printfn "%s" (fn 15.8)
//=> 15+

printfn "%s" (fn 1.0)
//=> 1-

printf "%s" (fn 12.5)
//=> 12
