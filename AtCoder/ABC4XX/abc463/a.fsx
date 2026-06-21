// https://atcoder.jp/contests/abc463/tasks/abc463_a

let fn x y =
    if x * 9 = y * 16 then
        "Yes"
    else
        "No"

printfn "%s" (fn 800 450)
//=> Yes

printfn "%s" (fn 234 108)
//=> No

printfn "%s" (fn 108 192)
//=> No
