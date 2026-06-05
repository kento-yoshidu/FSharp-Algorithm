// https://atcoder.jp/contests/abc391/tasks/abc391_a

let fn d =
    match d with
    | "N" -> "S"
    | "S" -> "N"
    | "W" -> "E"
    | "E" -> "W"
    | "NE" -> "SW"
    | "SW" -> "NE"
    | "NW" -> "SE"
    | "SE" -> "NW"
    | _ -> failwith "unreachable"

printfn "%s" (fn "N")
//=> S

printf "%s" (fn "SE")
//=> NW
