// https://atcoder.jp/contests/abc141/tasks/abc141_a

let fn s =
    match s with
    | "Sunny" -> "Cloudy"
    | "Rainy" -> "Sunny"
    | "Cloudy" -> "Rainy"
    | _ -> failwith "error"

printfn "%s" (fn "Sunny")
//=> Cloudy

printf "%s" (fn "Rainy")
//=> Sunny
