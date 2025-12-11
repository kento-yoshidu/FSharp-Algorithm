// https://atcoder.jp/contests/abc426/tasks/abc426_a

let fn x y =
    match (x, y) with
    | x, y when x = y -> "Yes"
    | "Serval", "Ocelot" -> "Yes"
    | "Lynx", _ -> "Yes"
    | _ -> "No"

printfn "%s" (fn "Serval" "Ocelot")
//=> Yes

printfn "%s" (fn "Serval" "Lynx")
//=> No

printfn "%s" (fn "Ocelot" "Ocelot")
//=> Yes
