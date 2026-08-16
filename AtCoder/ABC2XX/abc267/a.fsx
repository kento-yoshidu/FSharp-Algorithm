// https://atcoder.jp/contests/abc267/tasks/abc267_a

let fn s =
    match s with
    | "Friday"    -> 1
    | "Thursday"  -> 2
    | "Wednesday" -> 3
    | "Tuesday"   -> 4
    | _           -> 5

printfn "%i" (fn "Wednesday")
//=> 3

printfn "%i" (fn "Monday")
//=> 5
