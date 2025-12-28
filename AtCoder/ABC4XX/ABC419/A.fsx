// https://atcoder.jp/contests/abc419/tasks/abc419_a

let fn s =
    match s with
    | "red" -> "SSS"
    | "blue" -> "FFF"
    | "green" -> "MMM"
    | _ -> "Unknown"

printfn "%s" (fn "red")
//=> SSS

printfn "%s" (fn "atcoder")
//=> Unknown
