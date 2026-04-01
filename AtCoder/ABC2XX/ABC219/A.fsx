// https://atcoder.jp/contests/abc219/tasks/abc219_a

let fn x =
    match x with
    | x when x <= 39 -> string(40 - x)
    | x when x <= 69 -> string(70 - x)
    | x when x <= 89 -> string(90 - x)
    | _ -> "expert"

printfn "%s" (fn 56)
//=> 14

printfn "%s" (fn 32)
//=> 8

printfn "%s" (fn 0)
//=> 40

printfn "%s" (fn 100)
//=> expert
