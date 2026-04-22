// https://atcoder.jp/contests/abc188/tasks/abc188_a

let fn x y =
    if min x y + 3 > max x y then
        "Yes"
    else
        "No"

printfn "%s" (fn 3 5)
//=> Yes

printfn "%s" (fn 16 2)
//=> No

printfn "%s" (fn 12 15)
//=> No
