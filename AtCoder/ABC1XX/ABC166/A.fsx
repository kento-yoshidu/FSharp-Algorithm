// https://atcoder.jp/contests/abc166/tasks/abc166_a

let fn s =
    match s with
    | "ABC" -> "ARC"
    | _ -> "ABC"

printfn "%s" (fn "ABC")
//=> ARC
