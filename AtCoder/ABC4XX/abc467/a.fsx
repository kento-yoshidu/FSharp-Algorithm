// https://atcoder.jp/contests/abc467/tasks/abc467_a

let fn h w =
    if w * 400 >= h * h then
        "Yes"
    else
        "No"

printfn "%s" (fn 180 60)
//=> No

printfn "%s" (fn 182 188)
//=> Yes

printfn "%s" (fn 180 81)
//=> Yes
