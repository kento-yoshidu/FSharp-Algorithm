// https://atcoder.jp/contests/abc464/tasks/abc464_a

let fn s =
    let e = s |> String.filter ((=) 'E') |> String.length
    let w = s |> String.filter ((=) 'W') |> String.length

    if e > w then
        "East"
    else
        "West"

printfn "%s" (fn "EEWEW")
//=> East

printfn "%s" (fn "WWWWWWW")
//=> West
