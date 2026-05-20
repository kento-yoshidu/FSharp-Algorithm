// https://atcoder.jp/contests/abc362/tasks/abc362_a

let fn r g b c =
    match c with
    | "Blue"  -> min r g
    | "Red"   -> min g b
    | "Green" -> min r b
    | _       -> failwith "unreachable"

printfn "%i" (fn 20 30 10 "Blue")
//=> 20

printfn "%i" (fn 100 100 100 "Red")
//=> 100

printfn "%i" (fn 37 39 93 "Blue")
//=> 37
